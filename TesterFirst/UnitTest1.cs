using System.Diagnostics;

namespace OpenBrowserExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            // M‰‰ratle Chrome'i tee
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            // Loo uus protsess, et avada Chrome
            Process.Start(chromePath, "https://www.example.com");
        }
    }
}