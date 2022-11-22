using System.Collections.Generic;
using Games.Shared.Data;
using UnityEngine;

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
    }
}