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
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "ネン" },
                new string[] { "nen" },
                new string[] { "とし" },
                new string[] { "toshi" },
                new string[] { "year", "counter for years" }
            ),
            new KanjiInfo(
                "大",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "ダイ", "タイ" },
                new string[] { "dai", "tai" },
                new string[] { "おお(きい)" },
                new string[] { "oo(kii)" },
                new string[] { "large", "big"  }
            ),
            new KanjiInfo(
                "十",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "ジュウ" },
                new string[] { "juu" },
                new string[] { "とお", "と" },
                new string[] { "tou", "to" },
                new string[] { "ten", "10" }
            ),
            new KanjiInfo(
                "二",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "ニ", "ジ" },
                new string[] { "ni", "ji" },
                new string[] { "ふた(つ)" },
                new string[] { "futa(tsu)" },
                new string[] { "two", "2" }
            ),
            new KanjiInfo(
                "本",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "ホン" },
                new string[] { "hon" },
                new string[] { "もと" },
                new string[] { "moto" },
                new string[] { "book", "present", "true", "counter for long cylindrical things" }
            ),
            new KanjiInfo(
                "中",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "チュウ" },
                new string[] { "chuu" },
                new string[] { "なか", "うち", "あた(る)" },
                new string[] { "naka", "uchi", "ata(ru)" },
                new string[] { "in", "inside", "middle", "mean", "center" }
            ),
            new KanjiInfo(
                "長",
                new KanjiClass[] { KanjiClass.TOP_100_MOST_FREQUENT, KanjiClass.JLPT_N5 },
                new string[] { "チョウ" },
                new string[] { "chou" },
                new string[] { "なが(い)", "おさ" },
                new string[] { "naga(i)", "osa" },
                new string[] { "long", "leader", "superior", "senior" }
            ),
        };
    }
}