using System;
using System.Linq;

namespace ExerciseThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
                        
            var positiveEvenNumbers = numbers.Where(x => x > 0)
                .Select(num => Math.Pow(num, 2)).ToList();

            positiveEvenNumbers.ForEach(i => Console.WriteLine($"[{i}]"));
            

            //solution2
            numbers.Where(n => n > 0).Select(n => n * n).ToList().ForEach(n => Console.WriteLine(n));
            Console.ReadLine();
        }
    }
}
