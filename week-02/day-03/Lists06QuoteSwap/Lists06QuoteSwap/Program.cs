using System;
using System.IO;
using System.Collections.Generic;

namespace Lists06QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Also, print the sentence to the output with spaces in between.
            //expected: what i cannot create i do not understand
            //csere lehet igy is remove majd add
            //string cannot = list[5];
            //list.RemoveAt(5);
            //list.Insert(2, cannot);


            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            string change = list[2];
            list[2] = list[5];
            list[5] = change;

            foreach (var item in list)
            {
            Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
