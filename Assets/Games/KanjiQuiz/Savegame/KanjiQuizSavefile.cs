using System;
using System.Collections.Generic;
using Games.Shared.Util;
using Newtonsoft.Json;

namespace Games.KanjiQuiz.Savegame
{   
    public class KanjiQuizSymbolStats
    {
        // the time when the question was displayed
        public double Timestamp;
        // duration spent on the question
        public double Duration;
        // number of answer options
        public List<string> Answers;
        // list of guessed kanji + timestamp
        // min: 2 (first click on correct guess -> second click to advance to next question) 
        public List<Tuple<string, double>> Guesses;
    }
    
    public class KanjiQuizSavefile: SerializedSavefile
    {
        private static int HISTORY_SIZE = 20;
        
        [JsonProperty("kanji_stats")]
        public Dictionary<string, Queue<KanjiQuizSymbolStats>> KanjiStats = new();

        public bool showRomaji = true;
        public bool showEnglishTranslations = true;
        public double questionPanelFontSize = 40.0;

        public void AddKanjiStats(string symbol, KanjiQuizSymbolStats stats, bool writeToFile = true)
        {
            if (!KanjiStats.ContainsKey(symbol))
            {
                KanjiStats[symbol] = new Queue<KanjiQuizSymbolStats>(HISTORY_SIZE);
            }
            
            KanjiStats[symbol].Enqueue(stats);
            
            if (writeToFile)
            {
                WriteToFile();
            }
        }
        
        public override string GetSaveFileName()
        {
            return "kanji_quiz.savedata";
        }
    }
}