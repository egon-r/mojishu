using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

    public class KanjiInfo: IEqualityComparer<KanjiInfo>
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

        public bool Equals(KanjiInfo x, KanjiInfo y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.kanjiSymbol == y.kanjiSymbol;
        }

        public int GetHashCode(KanjiInfo obj)
        {
            return (obj.kanjiSymbol != null ? obj.kanjiSymbol.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"{kanjiSymbol}";
        }
    }

    public static class KanjiData
    {
        public static List<KanjiInfo> JLPT_N5_to_N1
        {
            get
            {
                return JLPT_N1.Concat(JLPT_N2).Concat(JLPT_N3).Concat(JLPT_N4).Concat(JLPT_N5).ToList();
            }
        }

        
        public static List<KanjiInfo> Top100_MostFrequent
        {
            get
            {
                return KanjiData_Top100MostFrequent.Kanji;
            }
        }

        public static List<KanjiInfo> JLPT_N5
        {
            get
            {
                return KanjiData_JLPT_N5.Kanji;
            }
        }
        
        public static List<KanjiInfo> JLPT_N4
        {
            get
            {
                return KanjiData_JLPT_N4.Kanji;
            }
        }
        
        public static List<KanjiInfo> JLPT_N3
        {
            get
            {
                return KanjiData_JLPT_N3.Kanji;
            }
        }
        
        public static List<KanjiInfo> JLPT_N2
        {
            get
            {
                return KanjiData_JLPT_N2.Kanji;
            }
        }
        
        public static List<KanjiInfo> JLPT_N1
        {
            get
            {
                return KanjiData_JLPT_N1.Kanji;
            }
        }
    }
}