using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Games.Shared.Util;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine;

namespace Games.Shared.Data
{
    public class KanjiInfo : IEqualityComparer<KanjiInfo>
    {
        public struct ExampleInfo
        {
            public string Kanji;
            public string Kana;
            public string English;
            
            public override string ToString()
            {
                return $"{Kanji} ({Kana}), {English}";
            }
        }

        public string Kanji;
        public string KaName;
        public List<ExampleInfo> Examples = new();
        public List<string> Onyomi = new();
        public List<string> Kunyomi = new();
        public List<string> Nanori = new();
        public List<string> English = new();
        public int? Jlpt;
        public int? Strokes;
        public int? UsageFreq2500;
        public int? Grade;
        public List<string> Radicals = new();

        public override string ToString()
        {
            return $"{Kanji} ({KaName})\n" +
                   $"\tON: {String.Join(", ", Onyomi)}\n" +
                   $"\tKUN: {String.Join(", ", Kunyomi)}\n" +
                   $"\tNAN: {String.Join(", ", Nanori)}\n" +
                   $"\tJLPT: {Jlpt}\n" +
                   $"\tGrade: {Grade}\n" +
                   $"\tUsage: {UsageFreq2500}\n" +
                   $"\tExample '0' of '{Examples.Count}': {Examples[0]}\n" +
                   $"\tStrokes: {Strokes}";
        }

        public bool Equals(KanjiInfo x, KanjiInfo y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Kanji == y.Kanji;
        }

        public int GetHashCode(KanjiInfo obj)
        {
            return (obj.Kanji != null ? obj.Kanji.GetHashCode() : 0);
        }
    }

    public class KanjiDataLoader
    {
        public Dictionary<string, KanjiInfo> KanjiData = new();

        public KanjiDataLoader()
        {
            
        }

        public IEnumerable<KanjiInfo> getMostFrequent(int count = 100)
        {
            return KanjiData.Values
                .Where(kanji => kanji.UsageFreq2500 != null)
                .OrderBy(kanji => kanji.UsageFreq2500)
                .Take(count);
        }

        public IEnumerable<KanjiInfo> getKanjiByGrade(int grade)
        {
            return KanjiData.Values.Where(kanji => kanji.Grade == grade);
        }

        public IEnumerable<KanjiInfo> getKanjiByJlpt(int jlpt)
        {
            return KanjiData.Values.Where(kanji => kanji.Jlpt == jlpt);
        }

        public void LoadData(string path, bool header = true)
        {
            var csvReader = new CSVReader(path);
            csvReader.ReadLines((line, lineNum) =>
            {
                if (lineNum == 0 && header)
                {
                    // Debug.Log($"Headers: {line}");
                }
                else
                {
                    var fields = csvReader.GetFields(line);
                    var kanjiInfo = CreateKanjiInfo(fields);
                    KanjiData[kanjiInfo.Kanji] = kanjiInfo;
                }
            });
        }
        
        private KanjiInfo CreateKanjiInfo(IList<string> fields)
        {
            // kanji, ka_name, ka_examples, onyomi, kunyomi, nanori, english, jlpt, strokes, freq, grade, radicals
            var kanjiInfo = new KanjiInfo();
            kanjiInfo.Kanji = fields[0];
            kanjiInfo.KaName = fields[1];

            var examplesStr = fields[2].Trim(' ', '"').Replace("\"\"", "\"");
            var examples = JsonConvert.DeserializeObject<List<List<string>>>(examplesStr);
            foreach (var example in examples)
            {
                var exampleSplit = example[0].Split('（');
                kanjiInfo.Examples.Add(new KanjiInfo.ExampleInfo
                {
                    Kanji = exampleSplit[0],
                    Kana = exampleSplit[1].TrimEnd('）'),
                    English = example[1]
                });
            }
            
            kanjiInfo.Onyomi.AddRange(fields[3].Split(", "));
            kanjiInfo.Kunyomi.AddRange(fields[4].Split(", "));
            kanjiInfo.Nanori.AddRange(fields[5].Split(", "));
            kanjiInfo.English.AddRange(fields[6].Split(", "));

            kanjiInfo.Jlpt = fields[7].toIntOrNull();
            kanjiInfo.Strokes = fields[8].toIntOrNull();
            kanjiInfo.UsageFreq2500 = fields[9].toIntOrNull();
            kanjiInfo.Grade = fields[10].toIntOrNull();
            
            kanjiInfo.Radicals.AddRange(fields[11].Split(", "));
            
            return kanjiInfo;
        }
    }
}