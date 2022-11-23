using System.Collections.Generic;
using Games.Shared.Util;
using Newtonsoft.Json;

namespace Games.KanaPairs.Savegame
{
    /// <summary>
    /// Stores persistent data for "Pairs" game. 
    /// </summary>
    public class PairsSaveData: SerializedSavefile
    {
        [JsonProperty("level_scores")]
        public Dictionary<string, int> LevelHighscores100 = new();
        
        public override string GetSaveFileName()
        {
            return "kana_pairs.savedata";
        }
    }
}