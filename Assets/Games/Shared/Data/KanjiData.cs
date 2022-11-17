using System.Collections.Generic;

namespace Games.Shared.Data
{
    public enum KanjiClass
    {
        JLPT_N1,
        JLPT_N2,
        JLPT_N3,
        JLPT_N4,
        JLPT_N5,
        TOP_100_MOST_FREQUENT,
    }

    public class KanjiInfo
    {
        public string kanjiSymbol;
        public List<string> onyomiReadingsKana;
        public List<string> onyomiReadingsLatin;
        public List<string> kunyomiReadingsKana;
        public List<string> kunyomiReadingsLatin;
        public List<string> englishTranslations;
        public List<KanjiClass> classes;

        public KanjiInfo(string kanjiSymbol, KanjiClass[] classes, 
            string[] onyomiReadingsKana, string[] onyomiReadingsLatin, 
            string[] kunyomiReadingsKana, string[] kunyomiReadingsLatin, 
            string[] englishTranslations)
        {
            this.kanjiSymbol = kanjiSymbol;
            this.classes = new List<KanjiClass>(classes);
            this.onyomiReadingsKana = new List<string>(onyomiReadingsKana);
            this.kunyomiReadingsKana = new List<string>(kunyomiReadingsKana);
            this.englishTranslations = new List<string>(englishTranslations);
            this.onyomiReadingsLatin = new List<string>(onyomiReadingsLatin);
            this.kunyomiReadingsLatin = new List<string>(kunyomiReadingsLatin);
        }
    }

    public static class KanjiData
    {
        public static List<KanjiInfo> AllKanji = new()
        {
            /*
            new KanjiInfo(
                "日",
                new KanjiClass[] { },
                new string[] { },
                new string[] {  },
                new string[] { },
                new string[] {  },
                new string[] {  }
            ),
            */
            new KanjiInfo(
                "日",
                new[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] {　"ニチ", "ジツ" },
                new string[] { "nichi", "jitsu" },
                new string[] { "ひ", "-び", "-か"},
                new string[] { "hi, -bi, -ka" },
                new string[] { "day", "sun", "Japan", "counter for days" }
            ),
            new KanjiInfo(
                "一",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "イチ" },
                new string[] { "ichi" },
                new string[] { "ひと(つ)" },
                new string[] { "hito(tsu)" },
                new string[] { "one" }
            ),
            new KanjiInfo(
                "国",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "コク" },
                new string[] { "koku" },
                new string[] { "くに" },
                new string[] { "kuni" },
                new string[] { "country" }
            ),
            new KanjiInfo(
                "会",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N4 },
                new string[] { "カイ" },
                new string[] { "kai" },
                new string[] { "あ(う)" },
                new string[] { "a(u)" },
                new string[] { "meeting", "meet" }
            ),
            new KanjiInfo(
                "人",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "ジン", "ニン" },
                new string[] { "jin", "nin" },
                new string[] { "ひと" },
                new string[] { "hito" },
                new string[] { "person" }
            ),
            new KanjiInfo(
                "年",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT },
                new string[] { "ネン" },
                new string[] { "nen" },
                new string[] { "とし" },
                new string[] { "toshi" },
                new string[] { "year", "counter for years" }
            ),
        };
    }
}