using System;

namespace M3U8_Downloader
{
    internal enum LogType
    {
        DEBUG = 1,
        INFO,
        WARN,
        ERROR,
        FATAL
    }
    internal static class LogTypeHelper
    {
        static Random rand = new Random();

        public static LogType Gen()
        {
            int Value = rand.Next(1, 6);
            LogType logType = (LogType)Enum.Parse(typeof(LogType), Value.ToString());
            return logType;
        }
    }
}
