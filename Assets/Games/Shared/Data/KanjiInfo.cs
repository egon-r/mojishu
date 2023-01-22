using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Application = UnityEngine.Device.Application;

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

        public string getVideoUrl()
        {
            return Path.Combine(Application.streamingAssetsPath, "Kanji", "video", $"{KaName}_00.mp4");
        }

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
}