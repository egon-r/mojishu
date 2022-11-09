using System.Collections.Generic;

namespace Games.Pairs
{
    public class PairsGameInitData
    {
        public Dictionary<string, string> Pairs;
        public int boardCols;
        public int boardRows;
        public float initialBoardRevealDuration;
        public string levelName;

        public PairsGameInitData(string levelName, int boardRows, int boardCols, float initialBoardRevealDuration, Dictionary<string, string> Pairs)
        {
            this.initialBoardRevealDuration = initialBoardRevealDuration;
            this.boardRows = boardRows;
            this.boardCols = boardCols;
            this.Pairs = Pairs;
            this.levelName = levelName;
        }
    }
}