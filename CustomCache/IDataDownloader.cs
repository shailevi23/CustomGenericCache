namespace CustomCache
{
    public interface IDataDownloader<T, S>
    {
        S DownloadData(T resourceId);
    }
}
