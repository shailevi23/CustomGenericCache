﻿using CustomCache.Cache;
using System;
using System.Collections.Generic;


namespace CustomCache
{
    class FetchData<T, S>
    {
        IDataDownloader<T, S> _dataDownloader;
        IGenericCache<T, S> _cache;


        public FetchData(IDataDownloader<T, S> dataDownloader, IGenericCache<T, S> cache)
        {
            _dataDownloader = dataDownloader;
            _cache = cache;
        }

        public void Run(IEnumerable<T> list)
        {
            foreach (T value in list)
            {
                Console.WriteLine(_cache.GetData(value, val => _dataDownloader.DownloadData(val)));
            }
        }
    }
}
