using System.Collections.Generic;
using System.Linq;
using Games.Shared.Data;
using Games.Shared.Util;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Games.KanjiQuiz
{
    public class KanjiQuizGame: MonoBehaviour
    {
        private KanjiInfo _currentKanji;
        public KanjiInfo CurrentKanji
        {
            get => _currentKanji;
        }
        
        public KanjiQuizAnswers AnswerGrid;
        public KanjiQuizQuestionPanel QuestionPanel;
        
        private void Start()
        {
            StartGame();
        }

        private void StartGame(int numAnswers = 6)
        {
            // randomly pick answer/option kanji
            _currentKanji = KanjiData.Top100_MostFrequent[Random.Range(0, KanjiData_Top100MostFrequent.Kanji.Count)];
            var answerOptionSet = new HashSet<KanjiInfo>() { _currentKanji };
            while (answerOptionSet.Count < numAnswers)
            {
                var randomKanji = KanjiData.Top100_MostFrequent[Random.Range(0, KanjiData_Top100MostFrequent.Kanji.Count)];
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
        }

        private void OnAnswerClicked(KanjiQuizAnswerCard card)
        {
            Debug.Log("clicked: " + card.Kanji);
            if (card.Kanji == _currentKanji)
            {
                Debug.Log("Correct!");
                StartGame();
            }
            else
            {
                card.MarkAsWrong();
            }
        }
    }
}