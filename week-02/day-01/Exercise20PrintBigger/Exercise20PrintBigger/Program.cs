using System;

namespace Exercise20PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("first number?");
            //string number1 = Console.ReadLine();
            //int number01 = int.Parse(number1);

            int number01 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("second number?");
            //string number2 = Console.ReadLine();
            //int number02 = int.Parse(number2);

            int number02 = Int32.Parse(Console.ReadLine());

            if (number01 > number02)
            {
                Console.WriteLine(number01);
            }

            else if (number01 == number02)
            {
                Console.WriteLine("Equals!");
            }

            else
            {
                Console.WriteLine(number02);
            }

            Console.ReadKey();
        }
    }
}
