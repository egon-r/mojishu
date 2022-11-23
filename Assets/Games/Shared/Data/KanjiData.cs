using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Games.Shared.Data
{
    public static partial class KanjiData
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
                var n1to5 = new[]
                {
                    KanjiSet.JLPT_N1, KanjiSet.JLPT_N2, KanjiSet.JLPT_N3, KanjiSet.JLPT_N4, KanjiSet.JLPT_N5
                };
                return AllKanjiList
                    .Where(k => n1to5.Intersect(k.kanjiSets).Count() == n1to5.Count())
                    .ToList();
            }
        }

        
        public static List<KanjiInfo> Top100_MostFrequent
        {
            get
            {
                return AllKanjiList.Where(k => k.kanjiSets.Contains(KanjiSet.TOP_100_MOST_FREQUENT)).ToList();
            }
        }

        public static List<KanjiInfo> JLPT_N5
        {
            get
            {
                return AllKanjiList.Where(k => k.kanjiSets.Contains(KanjiSet.JLPT_N5)).ToList();
            }
        }
        
        public static List<KanjiInfo> JLPT_N4
        {
            get
            {
                return AllKanjiList.Where(k => k.kanjiSets.Contains(KanjiSet.JLPT_N4)).ToList();
            }
        }
        
        public static List<KanjiInfo> JLPT_N3
        {
            get
            {
                return AllKanjiList.Where(k => k.kanjiSets.Contains(KanjiSet.JLPT_N3)).ToList();
            }
        }
        
        public static List<KanjiInfo> JLPT_N2
        {
            get
            {
                return AllKanjiList.Where(k => k.kanjiSets.Contains(KanjiSet.JLPT_N2)).ToList();
            }
        }
        
        public static List<KanjiInfo> JLPT_N1
        {
            get
            {
                return AllKanjiList.Where(k => k.kanjiSets.Contains(KanjiSet.JLPT_N1)).ToList();
            }
        }
    }
}