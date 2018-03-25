using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one

            Console.WriteLine(FindTheSubstring("green fox academy", "fox"));
            Console.ReadLine();
        }

        static int FindTheSubstring(string main, string sub)
        {
            for (int i = 0; i < main.Length - (sub.Length - 1); i++)
            {
                if (main.Substring(i, sub.Length) == sub)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}