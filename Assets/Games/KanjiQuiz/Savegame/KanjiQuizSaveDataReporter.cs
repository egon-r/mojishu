﻿using System;
using System.Collections.Generic;
using System.Linq;
using Games.Shared.Data;
using UnityEngine;
using UnityEngine.Diagnostics;
using Utils = Games.Shared.Util.Utils;

namespace Games.KanjiQuiz.Savegame
{
    public class KanjiQuizSaveDataReporter
    {
        private KanjiQuizSaveData saveData;

        public KanjiQuizSaveDataReporter(KanjiQuizSaveData saveData)
        {
            this.saveData = saveData;
        }

        public void PrintReport()
        {
            /*
            Debug.Log("SaveData:");
            foreach (var kv in saveData.KanjiStats)
            {
                Debug.Log(kv.Key + " ->");
                foreach (var stats in kv.Value)
                {
                    var datetime = Utils.UnixTimestampToDateTime(stats.LastSeen);
                    Debug.Log($"\tDuration: {stats.Duration}s");
                    Debug.Log($"\tLastSeen: {datetime}");
                    Debug.Log($"\tAnswers: {String.Join(", ", stats.Answers)}");
                    Debug.Log($"\tGuesses: {String.Join(", ", stats.Guesses)}");
                }
            }
            */
            
            // list all guessed right at least once
            Debug.Log("Latest correct guesses:");
            var correctlyGuessed = saveData.KanjiStats.Where(kv =>
            {
                var corrects = kv.Value.Count(stats => stats.Guesses.Count() == 1);
                return corrects > 0;
            });
            correctlyGuessed = correctlyGuessed.OrderByDescending(kv =>
            {
                return kv.Value.Last().LastSeen;
            });
            foreach (var kv in correctlyGuessed)
            {
                var corrects = kv.Value
                    .Where(stats => stats.Guesses.Count() == 1)
                    .Select(stats => stats.Guesses[0]);
                
                Debug.Log($"\t{kv.Key} -> {corrects.Count()}");

                var correctDates = corrects.Select(c => Utils.UnixTimestampToDateTime(c.Item2));
                Debug.Log($"\t{String.Join(", ", correctDates)}");
            }
            
            // list all memorized (guessed right 3 times in a row recently)
        }
    }
}