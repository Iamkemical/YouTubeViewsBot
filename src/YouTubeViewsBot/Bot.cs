using OpenQA.Selenium.Firefox;
using System;

namespace YouTubeViewsBot
{
    class Bot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static FirefoxDriver fireFoxDriver;
        static void Startup()
        {
            FirefoxOptions options = new FirefoxOptions();

            // Makes browser to hide
            options.AddArgument("--headless");
            FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();
            firefoxDriverService.HideCommandPromptWindow = true;
            fireFoxDriver = new FirefoxDriver(firefoxDriverService, options);
        }

        static void ViewVideo()
        {
            // 
        }
    }

    
}
