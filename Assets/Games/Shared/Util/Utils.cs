using System;
using System.Collections.Generic;
using Games.Shared.Data;
using Random = UnityEngine.Random;

namespace Games.Shared.Util
{
    public static class Utils
    {
        public static bool ContainsPair<T>(this IDictionary<T, T> dict, T first, T second)
        {
            if (dict.ContainsKey(first))
            {
                return EqualityComparer<T>.Default.Equals(dict[first], second);
            } else if (dict.ContainsKey(second))
            {
                return EqualityComparer<T>.Default.Equals(dict[second], first);
            }
            else
            {
                return false;
            }
        }

        public static double Remap (this double value, double from1, double to1, double from2, double to2) {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }
        
        public static object FindKey<K,V>(this IDictionary<K, V> dict, V value)
        {
            foreach (var kv in dict)
            {
                if (kv.Value.Equals(value))
                {
                    return kv.Key;
                }
            }
            return null;
        }

        public static double CurrentUnixTimestamp()
        {
            var dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return (DateTime.Now.ToUniversalTime() - dt1970).TotalSeconds;
        }

        public static DateTime UnixTimestampToDateTime(double timestamp)
        {
            var dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return dt1970.AddSeconds(timestamp).ToLocalTime();
        }
        
        /// <summary>
        /// Shuffle list based on Fisher-Yates
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        public static IList<T> Shuffle<T>(this IList<T> list)  
        {  
            int n = list.Count;  
            while (n > 1) {  
                n--;  
                int k = Random.Range(0, n + 1);  
                (list[k], list[n]) = (list[n], list[k]);
            }
            return list;
        }

        public static T? GetValueOrNull<T>(this T[] array, int index) where T: struct
        {
            if (array.Length < index)
            {
                return array[index];
            }
            return null;
        }
    }
}