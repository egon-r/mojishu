using System;
using System.Collections.Generic;
using Games.Shared.Util;
using Newtonsoft.Json;

namespace Games.KanjiQuiz.Savegame
{   
    public class KanjiSymbolStats
    {
        // timestamp in seconds when the kanji was last seen
        public float LastSeen;
        // duration spent on the question
        public float Duration;
        // number of answer options
        public List<string> Answers;
        // list of guessed kanji + timestamp
        public List<Tuple<string, float>> Guesses;
    }
    
    public class KanjiQuizSaveData: SerializedSavefile
    {
        private static int HISTORY_SIZE = 20;
        
        [JsonProperty("kanji_stats")]
        public Dictionary<string, Queue<KanjiSymbolStats>> KanjiStats = new();

        public void AddKanjiStats(string symbol, KanjiSymbolStats stats, bool writeToFile = true)
        {
            if (!KanjiStats.ContainsKey(symbol))
            {
                KanjiStats[symbol] = new Queue<KanjiSymbolStats>(HISTORY_SIZE);
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