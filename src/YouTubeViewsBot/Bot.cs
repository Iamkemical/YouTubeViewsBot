using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace YouTubeViewsBot
{
    class Bot
    {
        static void Main(string[] args)
        {
            // Initializes the Firefox driver
            Startup();

            // Initializes the youtube video
            ViewVideo();
        }

        public static FirefoxDriver fireFoxDriver;
        static void Startup()
        {
            FirefoxOptions options = new FirefoxOptions();

            // Makes browser to hide
            //options.AddArgument("--headless");
            FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();
            firefoxDriverService.HideCommandPromptWindow = true;
            fireFoxDriver = new FirefoxDriver(firefoxDriverService, options);
        }

        static void ViewVideo()
        {
            // Go the link of the video
            string url = "https://www.youtube.com/watch?v=oEILJYhx1RQ";
            fireFoxDriver.Navigate().GoToUrl(url);


            // No of views of the video
            int noOfViews = 1000;

            // Iterates the number of times the video is viewed
            for (int i = 1; i <= noOfViews; i++)
            {
                Thread.Sleep(10000);
                fireFoxDriver.Navigate().Refresh();
                
                ConsoleLog.ConsoleLogger($"Video viewed {i} times");
            }
            fireFoxDriver.Quit();
        }
    }

    
}
