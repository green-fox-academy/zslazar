using System;
using System.Linq;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:

            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //query syntax
            var number = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;
            //output 
            Console.WriteLine("query syntax output");
            foreach (var n in number)
            {
                Console.WriteLine($"[{n}]");
            }
            
            //method syntax
            var numbermethod = number.Where(x => (x % 2 == 0)).OrderBy(x => x);

            //output
            Console.WriteLine("method syntax output");
            foreach (var n1 in numbermethod)
            {
                Console.WriteLine($"[{n1}]");
            }

            Console.ReadLine();
        }
    }
}
