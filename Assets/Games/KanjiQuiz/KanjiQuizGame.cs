using System;
using System.Collections.Generic;
using System.Linq;
using DigitalRuby.Tween;
using Games.KanjiQuiz.Savegame;
using Games.Shared.Data;
using Games.Shared.Util;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Games.KanjiQuiz
{
    public class KanjiQuizGameInitData
    {
        public int NumAnswers;
        public bool ShowRomaji;
        public bool ShowEnglishTranslations;
        public string KanjiDatasetKey;

        public KanjiQuizGameInitData(bool showRomaji, bool showEnglishTranslations, string datasetKey, int numAnswers = 6)
        {
            ShowRomaji = showRomaji;
            ShowEnglishTranslations = showEnglishTranslations;
            NumAnswers = numAnswers;
            KanjiDatasetKey = datasetKey;
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
        public GridLayoutGroup AnswerGrid;
        public KanjiQuizQuestionPanel QuestionPanel;
        public KanjiQuizAnswerCard AnswerCardPrefab;
        private List<KanjiInfo> currentAnswerOptions;
        private double currentGameStartTime;
        private KanjiQuizSaveData saveData = new();
        private List<Tuple<string, double>> playerGuesses = new();
        private double realStartTime;
        
        public delegate void GameStartedEvent();

        public event GameStartedEvent GameStarted;

        private void OnEnable()
        {
            Debug.Log("KanjiQuizGame");
            var dataLoader = new KanjiDataLoader();
            
        }

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

        public void StartRound(KanjiQuizGameInitData initData)
        {
            saveData.ReadFromFile();

            var kanjiList = KanjiData.Datasets[initData.KanjiDatasetKey];
            playerGuesses.Clear();
            currentGameInitData = initData;
            
            // randomly pick answer kanji
            currentAnswer = kanjiList[Random.Range(0, kanjiList.Count)];
            Debug.Log("Answer Kanji: " + currentAnswer); 
            currentAnswerOptions = PickRandomKanji(kanjiList);
            
            // shuffle answer positions
            currentAnswerOptions = currentAnswerOptions.Shuffle().ToList();
           
            // spawn answers
            ClearAnswerGrid();
            SpawnCards(currentAnswerOptions);
            
            // update question panel
            QuestionPanel.ShowRomaji = initData.ShowRomaji;
            QuestionPanel.ShowEnglishTranslations = initData.ShowEnglishTranslations;
            QuestionPanel.Kanji = currentAnswer;

            // show the game
            realStartTime = Utils.CurrentUnixTimestamp();
            currentGameStartTime = Time.time;
            RaiseGameStarted();
            Show();
        }

        private void OnAnswerClicked(KanjiQuizAnswerCard card)
        {
            playerGuesses.Add(new Tuple<string, double>(card.Kanji.Kanji, Utils.CurrentUnixTimestamp()));
            if (card.Kanji == currentAnswer)
            {
                if (card.state == KanjiQuizAnswerCard.CardState.CORRECT)
                {
                    card.IgnorePointerEvents = true;
                    saveData.AddKanjiStats(card.Kanji.Kanji, new KanjiQuizSymbolStats()
                    {
                        Timestamp = realStartTime,
                        Answers = currentAnswerOptions.Select(k => k.Kanji).ToList(),
                        Duration = Time.time - currentGameStartTime,
                        Guesses = playerGuesses
                    });
                    StartRoundFinishedAnim(card, () =>
                    {
                        Destroy(card.gameObject);
                        StartRound(currentGameInitData);
                    });
                }
                else
                {
                    card.MarkAsCorrect();
                    StartHideAnswersAnim(card, () => {});
                }
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

        private void ClearAnswerGrid()
        {
            foreach (var child in AnswerGrid.transform)
            {
                var childTransform = child as Transform;
                if (childTransform != null)
                {
                    Destroy(childTransform.gameObject);
                }
            }
        }

        private void SpawnCards(IList<KanjiInfo> kanjiInfos)
        {
            foreach (var kanjiInfo in kanjiInfos)
            {
                var card = Instantiate(AnswerCardPrefab, AnswerGrid.transform);
                card.Kanji = kanjiInfo;
                card.Clicked += OnAnswerClicked;
            }
        }

        private void StartHideAnswersAnim(KanjiQuizAnswerCard ignoreCard, Action then)
        {
            var thenInvoked = false;
            foreach (var child in AnswerGrid.transform)
            {
                var childTransform = child as Transform;
                if (childTransform != null && childTransform.gameObject != ignoreCard.gameObject)
                {
                    var startRot = childTransform.rotation;
                    var endRot = Quaternion.Euler(0.0f, 0.0f, Random.Range(10.0f, 80.0f));
                    Action<ITween<Quaternion>> childRotAnim = (t) =>
                    {
                        childTransform.localRotation = t.CurrentValue;
                    };
                    gameObject.Tween(
                        childRotAnim, startRot, endRot, 0.4f,
                        TweenScaleFunctions.QuadraticEaseIn, childRotAnim
                    );

                    Action<ITween<Vector3>> childPosAnim = (t) =>
                    {
                        childTransform.localPosition = t.CurrentValue;
                    };
                    var startPos = childTransform.localPosition;
                    var endPos = new Vector3(
                        startPos.x + Random.Range(-600.0f, 600.0f), 
                        startPos.y - 1000.0f, 
                        startPos.z
                    );
                    gameObject.Tween(
                        childPosAnim, startPos, endPos, 0.8f,
                        TweenScaleFunctions.QuadraticEaseIn, childPosAnim,
                        _ =>
                        {
                            Destroy(childTransform.gameObject);
                            if (!thenInvoked)
                            {
                                thenInvoked = true;
                                then.Invoke();
                            }
                        }
                    );
                }
            }
        }
        
        private void StartRoundFinishedAnim(KanjiQuizAnswerCard answerCard, Action then)
        {
            var startScale = answerCard.transform.localScale;
            var endScale = startScale + new Vector3(1.0f, 1.0f, 1.0f);
            Action<ITween<Vector3>> answerAnim = (t) =>
            {
                answerCard.transform.localScale = t.CurrentValue;
                answerCard.CardBackground.color = new Color(255.0f, 255.0f, 255.0f, 1.0f - t.CurrentProgress);
                answerCard.CardText.color = new Color(255.0f, 255.0f, 255.0f, 1.0f - t.CurrentProgress);
            };
            gameObject.Tween(
                answerAnim, startScale, endScale, 0.6f, 
                TweenScaleFunctions.CubicEaseOut, answerAnim,
                _ => then.Invoke()
            );
        }
    }
}