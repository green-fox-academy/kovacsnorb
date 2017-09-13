using System;

namespace Strings_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            string url1 = url.Replace("bots","odds");
            url1 = url1.Insert(5, ":");

            string url2 = url.Substring(0, 5) + ":" + url.Substring(5, 33) + "odds";

            Console.WriteLine(url);
            Console.WriteLine(url1);
            Console.WriteLine(url2);
            Console.ReadLine();
        }
    }
}
