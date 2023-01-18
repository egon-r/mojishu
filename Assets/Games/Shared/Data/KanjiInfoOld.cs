using System.Collections.Generic;

namespace Games.Shared.Data
{
    public class KanjiInfoOld: IEqualityComparer<KanjiInfoOld>
    {
        public string kanjiSymbol;
        public List<string> onyomiReadingsKana;
        public List<string> onyomiReadingsLatin;
        public List<string> kunyomiReadingsKana;
        public List<string> kunyomiReadingsLatin;
        public List<string> englishTranslations;
        public HashSet<KanjiData.KanjiSet> kanjiSets;

        public KanjiInfoOld(string kanjiSymbol, KanjiData.KanjiSet[] kanjiSets,
            string[] onyomiReadingsKana, string[] onyomiReadingsLatin,
            string[] kunyomiReadingsKana, string[] kunyomiReadingsLatin,
            string[] englishTranslations)
        {
            this.kanjiSymbol = kanjiSymbol;
            this.kanjiSets = new HashSet<KanjiData.KanjiSet>(kanjiSets);
            this.onyomiReadingsKana = new List<string>(onyomiReadingsKana);
            this.kunyomiReadingsKana = new List<string>(kunyomiReadingsKana);
            this.englishTranslations = new List<string>(englishTranslations);
            this.onyomiReadingsLatin = new List<string>(onyomiReadingsLatin);
            this.kunyomiReadingsLatin = new List<string>(kunyomiReadingsLatin);
        }

        public bool Equals(KanjiInfoOld x, KanjiInfoOld y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.kanjiSymbol == y.kanjiSymbol;
        }

        public int GetHashCode(KanjiInfoOld obj)
        {
            return (obj.kanjiSymbol != null ? obj.kanjiSymbol.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return $"{kanjiSymbol}";
        }
    }
}