using System;
using System.Linq;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //query syntax
            var number = from n in numbers
                         where n % 2 != 0
                         select n;

            var result = number.Average();
            
            //output
            Console.WriteLine("query syntax output: " + result);
            
            //method syntax
            //var numberMethOddAverage = numbers.Where(x => (x % 2 != 0)).Average();
            var numberMethOddAverage = numbers.Where(x => (x % 2 == 1 || x % 2 == -1)).Average();

            //output
            Console.WriteLine("method syntax output: " + numberMethOddAverage);

            Console.ReadLine();
        }
    }
}
