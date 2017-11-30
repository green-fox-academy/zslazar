using System;

namespace Exercise19oneTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.WriteLine("give me a number");
            string number = Console.ReadLine();
            int numbers = int.Parse(number);

            if (numbers < 0)
            {
                Console.WriteLine("Not enough");
            }

            else if (numbers == 0)
            {
                Console.WriteLine("ifeltnothing");
            }

            else if (numbers == 1)
            {
                Console.WriteLine("One");
            }

            else if (numbers == 2)
            {
                Console.WriteLine("Two");
            }

            else 
            {
                Console.WriteLine("A lot");
            }

            Console.ReadLine();
        }
    }
}
