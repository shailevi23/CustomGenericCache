using System;

namespace CustomCache.Cache
{
    interface IGenericCache<TKey, TValue>
    {
        TValue GetData(TKey key, Func<TKey, TValue> downloadData);
    }
}
