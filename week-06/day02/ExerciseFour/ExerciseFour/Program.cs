using System;
using System.Linq;

namespace ExerciseFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            numbers.Where(n => n * n > 20).ToList().ForEach(n => Console.WriteLine($"[{n}]"));
            Console.ReadLine();
        }
    }
}
