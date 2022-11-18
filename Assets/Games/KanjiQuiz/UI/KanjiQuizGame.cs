using System;
using System.Collections.Generic;
using System.Linq;
using Games.Shared.Data;
using Games.Shared.Util;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Games.KanjiPairs
{
    public class KanjiQuizGame: MonoBehaviour
    {
        /*
         * - get random kanji description
         * - get 5/8/10 (depending on difficulty) more random kanji
         * - show description + answers
         */
        private void Start()
        {
            var kanjiToGuess = KanjiData.Top100_MostFrequent[Random.Range(0, KanjiData_Top100MostFrequent.Kanji.Count)];

            var answerOptionSet = new HashSet<KanjiInfo>() { kanjiToGuess };
            while (answerOptionSet.Count <= 6)
            {
                var randomKanji = KanjiData.Top100_MostFrequent[Random.Range(0, KanjiData_Top100MostFrequent.Kanji.Count)];
                answerOptionSet.Add(randomKanji);
            }

            var answerOptions = answerOptionSet.ToList().Shuffle();
            Debug.Log("To Guess: " + kanjiToGuess);
            Debug.Log("Options:");
            foreach (var option in answerOptions)
            {
                Debug.Log(option);
            }
        }
        
        
    }
}