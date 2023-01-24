using System;
using System.IO;
using System.Runtime.InteropServices;
using Kawazu;
using NMeCab.Core;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using Application = UnityEngine.Device.Application;

namespace Games.Shared.Util
{
    public static class JPConvert
    {
        public static KawazuConverter Converter = null;

        static JPConvert()
        {
            try
            {
                IFileLoader.FileLoaderType = typeof(StreamingAssetFileLoader);
                Converter = new KawazuConverter(Path.Combine(Application.streamingAssetsPath, "LibNMeCabDic"));
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }
        
        public static string KanaToRomaji(string kana)
        {
            return AsyncHelpers.RunSync<string>(() => Converter.Convert(kana, To.Romaji));
        }
    }

    public class StreamingAssetFileLoader : IFileLoader
    {
        [NativeDisableUnsafePtrRestriction]
        private GCHandle pinnedData;
        
        [NativeDisableUnsafePtrRestriction]
        private unsafe byte* dataPtr = null;
        
        private bool invoked = false;
        private long _fileSize = 0;
        public override long FileSize => _fileSize;

        public override BinaryReader CreateBinaryReader(string path)
        {
            var downloadHandler = StreamingAssetsUtils.getFinishedFileDownloadHandler(path);
            var memStream = new MemoryStream(downloadHandler.data);
            return new BinaryReader(memStream);
        }

        public override unsafe byte* Invoke(string file)
        {
            if (invoked)
            {
                return dataPtr;
            }
            
            var downloadHandler = StreamingAssetsUtils.getFinishedFileDownloadHandler(file);
            _fileSize = downloadHandler.data.Length;
            pinnedData = GCHandle.Alloc(downloadHandler.data, GCHandleType.Pinned);
            dataPtr = (byte*)pinnedData.AddrOfPinnedObject().ToPointer();
             
            invoked = true;
            return dataPtr;
        }

        public override void Dispose()
        {
            try
            {
                pinnedData.Free();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }
    }
}