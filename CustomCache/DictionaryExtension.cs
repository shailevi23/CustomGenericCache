using System.Collections.Generic;

namespace CustomCache
{
    public static class DictionaryExtension
    {
        public static TValue GetAndAddIfNotExists<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
            }

            return dictionary[key];
        }
    }
}
