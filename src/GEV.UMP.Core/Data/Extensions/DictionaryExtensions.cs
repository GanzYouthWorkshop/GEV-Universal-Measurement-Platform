using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Extensions
{
    public static class DictionaryExtensions
    {
        public static bool Set<K, V>(this Dictionary<K, V> dict, K key, V value)
        {
            if(dict.ContainsKey(key))
            {
                dict[key] = value;
                return true;
            }
            else
            {
                dict.Add(key, value);
                return false;
            }
        }
    }
}
