﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            
            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            ////Console.WriteLine(sampleString1.Replace("some","apple"));
            //url = url.Replace("bots", "odds");
            //url = url.Insert(5, ":");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}