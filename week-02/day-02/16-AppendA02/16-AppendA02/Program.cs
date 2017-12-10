using System;

namespace _16_AppendA02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimals = { "kuty", "macsk", "cic" };
            for (int i = 0; i < nimals.Length; i++)
            Console.WriteLine(AppendA(nimals[i]));
            Console.ReadLine();
        }

        static string AppendA (string word)
        {
            return word + "a";
        }
    }
}
