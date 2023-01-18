using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Games.Shared.Util;
using UnityEngine;

namespace Games.Shared.Data
{
    public class KanjiInfo
    {
        // "[ [ ""一年生（いちねんせい）"", ""first-year student"" ], [ ""一番（いちばん）"", ""number one"" ],...
        public struct ExampleInfo
        {
            public string Kanji;
            public string Kana;
            public string English;

            public override string ToString()
            {
                return $"{Kanji} ({Kana}): {English}";
            }
        }

        public struct KanaLatinString
        {
            public string Kana;
            public string Latin;
            
            public override string ToString()
            {
                return $"{Kana} ({Latin})";
            }
        }

        public string Kanji;
        public string Name;
        public int NumStrokes;
        public string English;
        public int Grade;
        public List<KanaLatinString> Kunyomi;
        public List<KanaLatinString> Onyomi;
        public List<ExampleInfo> Examples;
        public string Radical;
        public int RadicalOrder;
        public int RadicalNumStrokes;
        public KanaLatinString RadicalName;
        public string RadicalEnglish;
        public KanaLatinString RadicalPosition;

        public KanjiInfo()
        {
        }

        public override string ToString()
        {
            return $"{Kanji} ({Name}): \n" +
                   $"\tKUN: {String.Join(',', Kunyomi)}\n" +
                   $"\tON: {String.Join(',', Onyomi)}\n" +
                   $"\tEnglish: {English}\n" +
                   $"\tExamples: {String.Join(',', Examples)}\n" +
                   $"\tGrade: {Grade}\n" +
                   $"\tStrokes: {NumStrokes}\n" +
                   $"\tRadical: {Radical}\n"
                ;
        }
    }

    public class CSVReader
    {
        private bool abort = false;
        public string FilePath;

        public CSVReader(string filePath)
        {
            FilePath = filePath;
        }

        public void Abort()
        {
            abort = true;
        }

        public void ReadLines(Action<string, int> lineAction)
        {
            var reader = File.OpenText(FilePath);
            var lineCount = 0;
            while (reader.Peek() >= 0)
            {
                if (abort)
                {
                    abort = false;
                    return;
                }

                var line = reader.ReadLine();
                lineAction.Invoke(line, lineCount);
                lineCount++;
            }
        }

        public void ReadFields(string line, Action<string> fieldAction = null, Action<string, int> fieldIndexedAction = null)
        {
            var lineChars = line.ToCharArray();
            var field = "";
            var fieldCount = 0;
            var isString = false;
            var fieldCompleted = new Action(() =>
            {
                fieldAction?.Invoke(field);
                fieldIndexedAction?.Invoke(field, fieldCount);
                field = "";
                fieldCount++;
            });
            
            for (var i = 0; i < lineChars.Length; i++)
            {
                if (abort)
                {
                    abort = false;
                    return;
                }

                var c = lineChars[i];
                var nextC = lineChars.GetValueOrNull(i + 1);
                if (c == '"' && nextC != '"')
                {
                    isString = !isString;
                }

                if (c == ',' && !isString)
                {
                    fieldCompleted.Invoke();
                }
                else
                {
                    field += c;
                }
            }
            fieldCompleted.Invoke();
        }

        public IList<string> GetFields(string line)
        {
            var fields = new List<string>();
            ReadFields(line, fields.Add);
            return fields;
        }
    }

    public class KanjiDataLoader
    {
        public KanjiDataLoader()
        {
            Debug.Log("KanjiDataLoader");
            var dataFilePath = Path.Combine(Application.dataPath, "Games", "Shared", "Data", "Kanji", "ka_data.csv");

            var csvReader = new CSVReader(dataFilePath);
            csvReader.ReadLines((line, lineNum) =>
            {
                if (lineNum > 0)
                {
                    KanjiInfo kanjiInfo = new KanjiInfo();
                    var fields = csvReader.GetFields(line);
                    SetKanjiInfoFields(ref kanjiInfo, fields);
                    Debug.Log(kanjiInfo);
                    csvReader.Abort();
                }
            });
        }

        private void SetKanjiInfoFields(ref KanjiInfo kanjiInfo, IList<string> fields)
        {
            // kanji, kname, kstroke, kmeaning, kgrade, kunyomi_ja, kunyomi, onyomi_ja, onyomi, examples, radical, 
            // rad_order, rad_stroke, rad_name_ja, rad_name, rad_meaning, rad_position_ja, rad_position
            kanjiInfo.Kanji = fields[0];
            kanjiInfo.Name = fields[1];
            kanjiInfo.NumStrokes = int.Parse(fields[2]);
            kanjiInfo.English = fields[3];
            kanjiInfo.Grade = int.Parse(fields[4]);
            kanjiInfo.Kunyomi = MakeKanaLatinStringList(fields[5], fields[6]);
            kanjiInfo.Onyomi = MakeKanaLatinStringList(fields[7], fields[8]);
            kanjiInfo.Examples = MakeExamplesList(fields[9]);
            kanjiInfo.Radical = fields[10];
            kanjiInfo.RadicalOrder = int.Parse(fields[11]);
            kanjiInfo.RadicalNumStrokes = int.Parse(fields[12]);
            kanjiInfo.RadicalName.Kana = fields[13];
            kanjiInfo.RadicalName.Latin = fields[14];
            kanjiInfo.RadicalEnglish = fields[15];
            kanjiInfo.RadicalPosition.Kana = fields[16];
            kanjiInfo.RadicalPosition.Latin = fields[17];
        }

        private List<KanjiInfo.KanaLatinString> MakeKanaLatinStringList(string kanasStr, string latinsStr, string kanaSep = "、", string latinSep = ",")
        {
            var kanas = kanasStr.Split(kanaSep);
            var latins = latinsStr.Split(latinSep);
            if (kanas.Length != latins.Length)
            {
                Debug.LogWarning("kanas.Length != latins.Length");
            }

            var list = new List<KanjiInfo.KanaLatinString>();
            for (int i = 0; i < kanas.Length; i++)
            {
                list.Add(new KanjiInfo.KanaLatinString()
                {
                    Kana = kanas[i],
                    Latin = latins[i]
                });
            }

            return list;
        }

        private List<KanjiInfo.ExampleInfo> MakeExamplesList(string examplesStr)
        {
            // "[ [ ""一年生（いちねんせい）"", ""first-year student"" ], [ ""一番（いちばん）"", ""number one"" ],
            // [ ""一度（いちど）"", ""once"" ], [ ""一杯（いっぱい）"", ""one cup of, a lot of"" ],
            // [ ""一緒（いっしょ）"", ""together"" ], [ ""一分（いっぷん）"", ""one minute"" ],
            var examples = new List<KanjiInfo.ExampleInfo>();

            var exampleRx = new Regex("\\[(.*?)\\]"); // capture between [ and ]
            var exampleStrRx = new Regex("\"\"(.*?)\"\""); // capture between "" and ""

            foreach (Match exampleMatch in exampleRx.Matches(examplesStr))
            {
                var exampleStrMatches = exampleStrRx.Matches(exampleMatch.Groups[0].Value);
                var exampleStrJp = exampleStrMatches[0].Groups[1].Value;
                var exampleStrJpSplit = exampleStrJp.Split('（');
                
                var exampleStrEn = exampleStrMatches[1].Groups[1].Value;
                var exampleStrKana = exampleStrJpSplit[1].TrimEnd('）').Trim();
                var exampleStrKanji = exampleStrJpSplit[0].Trim();
                
                var example = new KanjiInfo.ExampleInfo()
                {
                    English = exampleStrEn,
                    Kana = exampleStrKana,
                    Kanji = exampleStrKanji
                };
                examples.Add(example);
            }
            
            return examples;
        }
    }
}