using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewsBot
{
    public class ConsoleLog
    {
        public static void ConsoleLogger(string s)
        {
            Console.WriteLine($"[{DateTime.Now}] {s}");
        }
    }
}
