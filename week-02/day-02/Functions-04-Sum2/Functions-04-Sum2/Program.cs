using System;

namespace Example
{
    class Program
    {
        // - Write a function called `sum` that sum all the numbers
        //   until the given parameter

        public static void Sum()
        {
            int number = int.Parse(Console.ReadLine());
            number = number * (number + 1) / 2;
            Console.WriteLine(number);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("give me a number");
            Sum();
            Console.ReadLine();
        }

    }
}