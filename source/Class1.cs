using System;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace acapi
{
    public static class Msg
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBoxW(
            IntPtr hWnd,
            string text,
            string caption,
            uint type);

        public static void Show(string text, string title)
        {
            MessageBoxW(IntPtr.Zero, text, title, 0x0);
        }
    }

    public static class Timer
    {
        public static void Wait(int seconds)
        {
            if (seconds <= 0)
                return;

            Thread.Sleep(seconds * 1000);
        }
    }
}
