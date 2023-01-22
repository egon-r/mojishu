using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace Games.Shared.Data
{
    public class KanjiData
    {
        public static Dictionary<string, List<KanjiInfo>> Datasets = new();

        static KanjiData()
        {
            var dataLoader = new KanjiDataLoader();
            dataLoader.LoadData(Path.Combine(Application.streamingAssetsPath, "Kanji", "kanji_data.csv"));
            
            Datasets["Top 100 Most Used"] = dataLoader.getMostFrequent(100).ToList();
            Datasets["Grade 1"] = dataLoader.getKanjiByGrade(1).ToList();
            Datasets["Grade 2"] = dataLoader.getKanjiByGrade(2).ToList();
            Datasets["Grade 3"] = dataLoader.getKanjiByGrade(3).ToList();
            Datasets["Grade 4"] = dataLoader.getKanjiByGrade(4).ToList();
            Datasets["Grade 5"] = dataLoader.getKanjiByGrade(5).ToList();
            Datasets["Grade 6"] = dataLoader.getKanjiByGrade(6).ToList();
            Datasets["Grade 8"] = dataLoader.getKanjiByGrade(8).ToList();
        }
    }
}