using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;

namespace Games.Shared.Util
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class SerializedSavefile
    {
        public abstract string GetSaveFileName();

        public virtual byte[] ToBytes(bool withCompression = true)
        {
            var json = JsonConvert.SerializeObject(this);
            var bytes = Encoding.UTF8.GetBytes(json);

            if (withCompression)
            {
                using (var memStream = new MemoryStream())
                {
                    using (var gzstream = new GZipStream(memStream, CompressionMode.Compress))
                    {
                        gzstream.Write(bytes);
                    }

                    return memStream.ToArray();
                }
            }

            return bytes;
        }

        public virtual void FromBytes(byte[] bytes, bool withCompression = true)
        {
            if (withCompression)
            {
                using (var memStream = new MemoryStream(bytes))
                {
                    using (var outStream = new MemoryStream())
                    {
                        using (var gzstream = new GZipStream(memStream, CompressionMode.Decompress))
                        {
                            gzstream.CopyTo(outStream);
                        }
                        var json = Encoding.UTF8.GetString(outStream.ToArray());
                        JsonConvert.PopulateObject(json, this);
                    }
                }
            }
            else
            {
                var json = Encoding.UTF8.GetString(bytes);
                JsonConvert.PopulateObject(json, this);
            }
        }

        public bool WriteToFile()
        {
            try
            {
                var fullPath = Path.Combine(Application.persistentDataPath, GetSaveFileName());
                Debug.Log($"Writing savedata: {fullPath}");
                File.WriteAllBytes(fullPath, ToBytes());
                return true;
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                return false;
            }
        }

        public bool ReadFromFile()
        {
            try
            {
                var fullPath = Path.Combine(Application.persistentDataPath, GetSaveFileName());
                Debug.Log($"Reading savedata: {fullPath}");
                FromBytes(File.ReadAllBytes(fullPath));
                return true;
            }
            catch (FileNotFoundException e)
            {
                Debug.LogWarning(e);
                return false;
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                return false;
            }
        }
    }
}