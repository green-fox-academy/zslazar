using System;
using System.Linq;

namespace ExerciseFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfNumbers = numbers.OrderByDescending(n => n).GroupBy(n => n)
               .ToDictionary(n => n.Key, n => n.Count());

            foreach (var item in frequencyOfNumbers)

            Console.WriteLine($"{item.Key} {item.Value}");
            Console.ReadLine();

        }
    }
}
