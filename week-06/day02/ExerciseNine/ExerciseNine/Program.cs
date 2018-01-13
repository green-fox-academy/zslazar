using System;
using System.Linq;

namespace ExerciseNine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] elements = { 'n', 'e', 'w', 'y', 'o', 'r', 'k' };

            //solution1
            string word = string.Join(",", elements).ToString();
            //string word = String.Join(",", elements).ToString();
            Console.WriteLine(word);

            //solution2
            string word2 = string.Join(string.Empty, elements);
            Console.WriteLine(word2);

            Console.ReadLine();
        }
    }
}
