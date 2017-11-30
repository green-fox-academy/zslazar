using System;

namespace Exercise18OddEven
{
    class Program

    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

            Console.WriteLine("Give me a number");
            string number = Console.ReadLine();
            int numbers = int.Parse(number);

            //i % 2 == 0
            
            if (numbers % 2 == 1)
            {
                Console.WriteLine("Even");
            }
        

            else 
            {
                Console.WriteLine("Odd");
            }
            Console.ReadLine();
        }
    }
}