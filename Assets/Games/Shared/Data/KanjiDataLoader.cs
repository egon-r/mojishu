using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Games.Shared.Util;
using Newtonsoft.Json;
using UnityEngine;

namespace Games.Shared.Data
{
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
            var csvReader = new CSVReader();
            var csvText = StreamingAssetsUtils.getFileAsString(Path.Combine("Kanji", "kanji_data.csv"));
            var lineNum = 0;
            foreach (var line in csvText.Split('\n'))
            {
                if (lineNum == 0 && header)
                {
                    // Debug.Log($"Headers: {line}");
                }
                else if(line.Length > 0)
                {
                    try
                    {
                        var fields = csvReader.GetFields(line.Trim());
                        var kanjiInfo = CreateKanjiInfo(fields);
                        KanjiData[kanjiInfo.Kanji] = kanjiInfo;
                    }
                    catch (Exception e)
                    {
                        Debug.LogError($"Error loading line {lineNum}: '{line}'");
                        Debug.LogError(e.Message);
                    }
                }
                lineNum++;
            }
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

            kanjiInfo.Onyomi.AddRange(fields[3].Trim('"').Split(", "));
            kanjiInfo.Kunyomi.AddRange(fields[4].Trim('"').Split(", "));
            kanjiInfo.Nanori.AddRange(fields[5].Trim('"').Split(", "));
            kanjiInfo.English.AddRange(fields[6].Trim('"').Split(", "));

            kanjiInfo.Jlpt = fields[7].toIntOrNull();
            kanjiInfo.Strokes = fields[8].toIntOrNull();
            kanjiInfo.UsageFreq2500 = fields[9].toIntOrNull();
            kanjiInfo.Grade = fields[10].toIntOrNull();

            kanjiInfo.Radicals.AddRange(fields[11].Trim('"').Split(", "));

            return kanjiInfo;
        }
    }
}