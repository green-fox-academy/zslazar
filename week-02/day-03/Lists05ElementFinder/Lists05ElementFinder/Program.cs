﻿using System;
using System.Collections.Generic;

namespace Lists05ElementFinder
{
    class Program
    {
        static void Main(string[] args)
            // Check if the arrayList contains "7" if it contains print "Hoorray" otherwise print "Noooooo"
            // Do this again with a different solution using different list functions!
        {
            var List = new List<int> { 1, 2, 7, 4, 5 };

            if (List.Contains(7))
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Noooooo");
            }

            Console.ReadLine();
        }
    }
}
