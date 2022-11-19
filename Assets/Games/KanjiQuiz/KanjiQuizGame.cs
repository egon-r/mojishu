using System.Collections.Generic;
using System.Linq;
using Games.Shared.Data;
using Games.Shared.Util;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Games.KanjiQuiz
{
    public class KanjiQuizGameInitData
    {
        public int numAnswers;
        public KanjiSet[] kanjiSets;

        public KanjiQuizGameInitData(int numAnswers = 6, params KanjiSet[] kanjiSets)
        {
            this.numAnswers = numAnswers;
            this.kanjiSets = kanjiSets;
        }
    }
    
    public class KanjiQuizGame: MonoBehaviour
    {
        private KanjiInfo _currentKanji;
        public KanjiInfo CurrentKanji
        {
            get => _currentKanji;
        }
        
        public KanjiQuizAnswers AnswerGrid;
        public KanjiQuizQuestionPanel QuestionPanel;
        private KanjiQuizGameInitData currentGameInitData;

        public void Hide()
        {
            gameObject.SetActive(false);
        }
        
        public void Show()
        {
            gameObject.SetActive(true);
        }
        
        public void StartGame(KanjiQuizGameInitData initData)
        {
            currentGameInitData = initData;
            
            // get kanji list
            var kanjiList = KanjiData.getKanjiSet(currentGameInitData.kanjiSets);
            if (kanjiList.Count < currentGameInitData.numAnswers)
            {
                Debug.LogError("selected kanji list is too small!");
                return;
            }
            
            // randomly pick answer/option kanji
            _currentKanji = kanjiList[Random.Range(0, kanjiList.Count)];
            var answerOptionSet = new HashSet<KanjiInfo>() { _currentKanji };
            while (answerOptionSet.Count < currentGameInitData.numAnswers)
            {
                var randomKanji = kanjiList[Random.Range(0, kanjiList.Count)];
                answerOptionSet.Add(randomKanji);
            }
            
            // shuffle option positions
            var answerOptions = answerOptionSet.ToList().Shuffle();
           
            // spawn options
            AnswerGrid.SpawnCards(answerOptions, card =>
            {
                card.Clicked += OnAnswerClicked;
            });
            
            // update question panel
            QuestionPanel.Kanji = _currentKanji;
            
            // debug
            Debug.Log("Answer: " + _currentKanji);
            Debug.Log("Options:");
            foreach (var option in answerOptions)
            {
                Debug.Log("\t" + option);
            }
            
            Show();
        }

        private void OnAnswerClicked(KanjiQuizAnswerCard card)
        {
            Debug.Log("clicked: " + card.Kanji);
            if (card.Kanji == _currentKanji)
            {
                Debug.Log("Correct!");
                StartGame(currentGameInitData);
            }
            else
            {
                card.MarkAsWrong();
            }
        }
    }
}