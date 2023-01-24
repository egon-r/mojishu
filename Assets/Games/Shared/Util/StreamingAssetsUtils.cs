using System;
using System.Diagnostics;
using System.IO;
using UnityEngine.Device;
using UnityEngine.Networking;

namespace Games.Shared.Util
{
    public class StreamingAssetsUtils
    {
        public static DownloadHandler getFinishedFileDownloadHandler(string path, int timeoutMs = 2000)
        {
            var fileReq = UnityWebRequest.Get(path);
            fileReq.SendWebRequest();
            
            var timeoutWatch = new Stopwatch();
            timeoutWatch.Start();
            while (!fileReq.isDone)
            {
                // waiting...
                if (timeoutWatch.ElapsedMilliseconds > timeoutMs)
                {
                    throw new Exception($"Timeout while requesting '{path}'!");
                }
            }

            if (fileReq.result != UnityWebRequest.Result.Success)
            {
                throw new Exception($"UnityWebRequest failed for '{path}'!");
            }

            return fileReq.downloadHandler;
        }
        
        public static string getFileAsString(string relPath, int timeoutMs = 2000)
        {
            var absPath = Path.Combine(Application.streamingAssetsPath, relPath);
            var downloadHandler = getFinishedFileDownloadHandler(absPath, timeoutMs);
            return downloadHandler.text;
        }
    }
}