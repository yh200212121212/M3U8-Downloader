using System;
using System.Runtime.InteropServices;

namespace M3U8_Downloader
{
    internal static class NativeMethod
    {
        [DllImport("kernel32.dll")]
        public static extern bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);
        [DllImport("kernel32.dll")]
        public static extern bool SetConsoleCtrlHandler(IntPtr handlerRoutine, bool add);
        [DllImport("kernel32.dll")]
        public static extern bool AttachConsole(int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();
        [DllImport("user32.dll")]
        public static extern bool FlashWindow(IntPtr hWnd, bool bInvert);
    }
}
