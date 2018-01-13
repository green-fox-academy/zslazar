using System;
using System.Linq;

namespace ExerciseSix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!

            string sting = "Englishman in New York";

            var frequencyOfLetters = sting.GroupBy(n => n)
               .ToDictionary(n => n.Key, n => n.Count());

            foreach (var item in frequencyOfLetters)
            
            Console.WriteLine($"{item.Key} {item.Value}");
            Console.ReadLine();
        }
    }
}
