using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Games.Shared.Data
{
    public static class KanjiData
    {
        public enum KanjiSet
        {
            JLPT_N1,
            JLPT_N2,
            JLPT_N3,
            JLPT_N4,
            JLPT_N5,
            TOP_100_MOST_FREQUENT,
        }

        public static Dictionary<KanjiSet, string> KanjiSetFriendlyNames = new()
        {
            { KanjiSet.JLPT_N1, "JLPT N1" },
            { KanjiSet.JLPT_N2, "JLPT N2" },
            { KanjiSet.JLPT_N3, "JLPT N3" },
            { KanjiSet.JLPT_N4, "JLPT N4" },
            { KanjiSet.JLPT_N5, "JLPT N5" },
            { KanjiSet.TOP_100_MOST_FREQUENT, "Top 100 Most Frequent" },
        };

        public static List<KanjiInfo> getKanjiSet(KanjiSet selectedSet)
        {
            switch (selectedSet)
            {
                case KanjiSet.JLPT_N1:
                    return JLPT_N1;
                case KanjiSet.JLPT_N2:
                    return JLPT_N2;
                case KanjiSet.JLPT_N3:
                    return JLPT_N3;
                case KanjiSet.JLPT_N4:
                    return JLPT_N4;
                case KanjiSet.JLPT_N5:
                    return JLPT_N5;
                case KanjiSet.TOP_100_MOST_FREQUENT:
                    return Top100_MostFrequent;
                default:
                    return new List<KanjiInfo>();
            }
        }
        
        public static List<KanjiInfo> getKanjiSet(params KanjiSet[] selectedSets)
        {
            // use a set because there might be duplicates
            var tmpSet = new HashSet<KanjiInfo>();
            foreach (var set in selectedSets)
            {
                foreach (var kanji in getKanjiSet(set))
                {
                    tmpSet.Add(kanji);
                }
            }
            return tmpSet.ToList();
        }

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