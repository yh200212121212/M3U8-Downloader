using System;

namespace M3U8_Downloader
{
    internal static class FileNameHelper
    {
        public  static string GetFileName()
        {
            return "Video" + DateTime.Now.ToString().Replace('/', '_').Replace(':', '_').Replace(' ', '-');
        }
    }
}
