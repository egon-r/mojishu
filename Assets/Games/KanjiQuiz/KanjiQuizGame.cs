using System;
using System.Collections.Generic;
using System.Linq;
using Games.KanjiQuiz.Savegame;
using Games.Shared.Data;
using Games.Shared.Util;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Games.KanjiQuiz
{
    public class KanjiQuizGameInitData
    {
        public int NumAnswers;
        public KanjiData.KanjiSet[] KanjiSets;
        public bool ShowRomaji;
        public bool ShowEnglishTranslations;

        public KanjiQuizGameInitData(bool showRomaji, bool showEnglishTranslations, int numAnswers = 6, params KanjiData.KanjiSet[] kanjiSets)
        {
            ShowRomaji = showRomaji;
            ShowEnglishTranslations = showEnglishTranslations;
            this.NumAnswers = numAnswers;
            this.KanjiSets = kanjiSets;
        }
    }
    
    public class KanjiQuizGame: MonoBehaviour
    {
        private KanjiInfo currentAnswer;
        public KanjiInfo CurrentKanji
        {
            get => currentAnswer;
        }
        
        public KanjiQuizGameInitData currentGameInitData;
        private List<KanjiInfo> currentAnswerOptions;
        private float currentGameStartTime;
        public KanjiQuizAnswers AnswerGrid;
        public KanjiQuizQuestionPanel QuestionPanel;
        private KanjiQuizSaveData saveData = new();
        private List<Tuple<string, float>> playerGuesses = new();
        private float realStartTime;
        
        public delegate void GameStartedEvent();

        public event GameStartedEvent GameStarted;

        public void Hide()
        {
            gameObject.SetActive(false);
        }
        
        public void Show()
        {
            gameObject.SetActive(true);
        }

        private List<KanjiInfo> PickRandomKanji(IList<KanjiInfo> fromList, bool considerCurrentKanji = true)
        {
            var answerOptionSet = new HashSet<KanjiInfo>() { currentAnswer };
            while (answerOptionSet.Count < currentGameInitData.NumAnswers)
            {
                var randomKanji = fromList[Random.Range(0, fromList.Count())];
                answerOptionSet.Add(randomKanji);
            }

            return answerOptionSet.ToList();
        }

        public void StartGame(KanjiQuizGameInitData initData)
        {
            saveData.ReadFromFile();
                
            playerGuesses.Clear();
            currentGameInitData = initData;
            
            // get kanji list
            var kanjiList = KanjiData.getKanjiSet(currentGameInitData.KanjiSets);
            if (kanjiList.Count < currentGameInitData.NumAnswers)
            {
                Debug.LogError("selected kanji list is too small!");
                return;
            }
            
            // randomly pick answer kanji
            currentAnswer = kanjiList[Random.Range(0, kanjiList.Count)];
            currentAnswerOptions = PickRandomKanji(kanjiList);
            
            // shuffle answer positions
            currentAnswerOptions = currentAnswerOptions.Shuffle().ToList();
           
            // spawn answers
            AnswerGrid.SpawnCards(currentAnswerOptions, card =>
            {
                card.Clicked += OnAnswerClicked;
            });
            
            // update question panel
            QuestionPanel.ShowRomaji = initData.ShowRomaji;
            QuestionPanel.ShowEnglishTranslations = initData.ShowEnglishTranslations;
            QuestionPanel.Kanji = currentAnswer;

            // show the game
            realStartTime = (float)Utils.CurrentUnixTimestamp();
            currentGameStartTime = Time.time;
            RaiseGameStarted();
            Show();
        }

        private void OnAnswerClicked(KanjiQuizAnswerCard card)
        {
            playerGuesses.Add(new Tuple<string, float>(card.Kanji.kanjiSymbol, (float)Utils.CurrentUnixTimestamp()));
            if (card.Kanji == currentAnswer)
            {
                saveData.AddKanjiStats(card.Kanji.kanjiSymbol, new KanjiQuizSymbolStats()
                {
                    LastSeen = realStartTime,
                    Answers = currentAnswerOptions.Select(k => k.kanjiSymbol).ToList(),
                    Duration = Time.time - currentGameStartTime,
                    Guesses = playerGuesses
                });
                StartGame(currentGameInitData);
            }
            else
            {
                card.MarkAsWrong();
            }
        }

        protected virtual void RaiseGameStarted()
        {
            GameStarted?.Invoke();
        }
    }
}