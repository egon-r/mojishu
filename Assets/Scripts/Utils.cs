using System.Collections;
using System.Collections.Generic;

namespace DefaultNamespace
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
    }
}