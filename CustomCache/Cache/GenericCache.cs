using System;
using System.Collections.Generic;

namespace CustomCache.Cache
{
    public class GenericCache<TKey, TValue> : IGenericCache<TKey, TValue>
    {
        public Dictionary<TKey, TValue> Dict { get; set; }

        public GenericCache()
        {
            Dict = new Dictionary<TKey, TValue>();
        }

        public TValue GetData(TKey key, Func<TKey, TValue> downloadData)
        {
            if(Dict.ContainsKey(key))
            {
                return Dict[key];
            }

            return Dict.GetAndAddIfNotExists(key, downloadData(key));
        }
    }
}
