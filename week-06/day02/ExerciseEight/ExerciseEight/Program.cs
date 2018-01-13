using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseEight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!
            string sting = "Englishman in New York";

            //number of uppercase characters
            var upperChar = sting.Count(c => Char.IsUpper(c));
            Console.WriteLine(upperChar);

            //the uppercase characters
            IEnumerable<char> query = from ch in sting where Char.IsUpper(ch) select ch;
            foreach (var c in query)
            Console.WriteLine(c);

            //solution2 - the uppercase characters
            sting.Where(s => s.ToString()
                .ToUpper() == s.ToString())
                .ToList()
                .ForEach(s => Console.WriteLine(s));

            Console.ReadLine();
        }
    }
}
