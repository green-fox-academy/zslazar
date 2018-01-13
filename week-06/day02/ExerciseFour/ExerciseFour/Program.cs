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

            //solution1
            var SquaredNumber = numbers.Where(num => Math.Pow(num, 2) > 20).ToList();
            //var highSquaredNumber = n.Where(num => Math.Pow(num, 2) > 20).Select(x => Math.Pow(x, 2)).ToList();
            SquaredNumber.ForEach(i => Console.WriteLine($"[{i}]"));

            //solution2
            numbers.Where(n => n * n > 20).ToList().ForEach(n => Console.WriteLine($"[{n}]"));
            Console.ReadLine();
        }
    }
}
