using CustomCache.Cache;
using System;
using System.Collections.Generic;

namespace CustomCache
{
    class Program
    {
        static void Main(string[] args)
        {
            var idList = new List<string> { "id1", "id2", "id3", "id1", "id3", "id1", "id2" };

            var fetch = new FetchData<string, string>(new SlowDataDownloader(), new GenericCache<string, string>());
            fetch.Run(idList);

            Console.ReadKey();
        }
    }
}
