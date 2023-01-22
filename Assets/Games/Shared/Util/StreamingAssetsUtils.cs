using System;
using System.Diagnostics;
using System.IO;
using UnityEngine.Device;
using UnityEngine.Networking;
using Debug = UnityEngine.Debug;

namespace Games.Shared.Util
{
    public class StreamingAssetsUtils
    {
        public static string getFileAsString(string relPath, int timeoutMs = 2000)
        {
            var reqPath = Path.Combine(Application.streamingAssetsPath, relPath);
            var fileReq = UnityWebRequest.Get(reqPath);
            fileReq.SendWebRequest();
            
            var timeoutWatch = new Stopwatch();
            timeoutWatch.Start();
            while (!fileReq.isDone)
            {
                // waiting...
                if (timeoutWatch.ElapsedMilliseconds > timeoutMs)
                {
                    throw new Exception($"Timeout while requesting '{reqPath}'!");
                }
            }

            if (fileReq.result != UnityWebRequest.Result.Success)
            {
                throw new Exception($"UnityWebRequest failed for '{reqPath}'!");
            }
         
            return fileReq.downloadHandler.text;
        }
    }
}