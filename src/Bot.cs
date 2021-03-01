using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using System;
using System.Threading;

namespace YouTubeViewsBot
{
    public class Bot
    {
        static void Main(string[] args)
        {
            // Initializes the Firefox driver
            Startup();

            // Initializes the youtube video
            ViewVideo("https://www.youtube.com/watch?v=oEILJYhx1RQ", 1000);
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

        
        static void ViewVideo(string url, int noOfViews)
        {
            // Go the link of the video
            fireFoxDriver.Navigate().GoToUrl(url);

            ConsoleLog.ConsoleLogger("Video launched successfully!");

            Thread.Sleep(1000);

            // Iterates the number of times the video is viewed
            for (int i = 1; i <= noOfViews; i++)
            {
                Thread.Sleep(10000);
                Actions action = new Actions(fireFoxDriver);
                IWebElement webElementLocator = fireFoxDriver.FindElementById("primary");

                action.Click(webElementLocator).Perform();

                fireFoxDriver.Navigate().Refresh();
                ConsoleLog.ConsoleLogger($"Video viewed {i} times");
            }
            fireFoxDriver.Quit();
        }
    }

    
}
