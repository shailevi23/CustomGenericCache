﻿using System.Threading;

namespace CustomCache
{
    public class SlowDataDownloader : IDataDownloader<string, string>
    {
        public string DownloadData(string resourceId)
        {
            //let's imagine this method downloads real data,
            //and it does it slowly
            Thread.Sleep(1000);
            return $"Some data for {resourceId}";
        }
    }
}
