using System;
using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine;

namespace Games.Pairs.Savegame
{
    [System.Serializable]
    public class PairsSaveData
    {
        public Dictionary<string, int> LevelHighscores100 = new Dictionary<string, int>();

        public bool WriteToFile(string fileName = "pairs_save.json")
        {
            try
            {
                var fullPath = Path.Combine(Application.persistentDataPath, fileName);
                Debug.Log($"Writing savedata: {fullPath}");
                File.WriteAllText(fullPath, ToJson());
                return true;
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                return false;
            }
        }

        public bool ReadFromFile(string fileName = "pairs_save.json")
        {
            try
            {
                var fullPath = Path.Combine(Application.persistentDataPath, fileName);
                Debug.Log($"Reading savedata: {fullPath}");
                LoadFromJson(File.ReadAllText(fullPath));
                return true;
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                return false;
            }
        }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void LoadFromJson(string json)
        {
            JsonConvert.PopulateObject(json, this);
        }
    }
}