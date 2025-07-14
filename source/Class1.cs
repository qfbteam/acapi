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

public static class AcVer
{
    public static string GetVersionFromUrl(string url)
    {
        try
        {
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                string searchKey = "\"version\"";
                int index = json.IndexOf(searchKey);
                if (index >= 0)
                {
                    int start = json.IndexOf('"', index + searchKey.Length + 1) + 1;
                    int end = json.IndexOf('"', start);
                    if (start > 0 && end > start)
                    {
                        return json.Substring(start, end - start);
                    }
                }
                return "version not found";
            }
        }
        catch (Exception ex)
        {
            return $"error: {ex.Message}";
        }
    }

    public static string Version => GetVersionFromUrl("https://raw.githubusercontent.com/Azurion-luau/acapi/refs/heads/main/version.json");
}
