using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13
            int number0 = 13;
            int number1 = 22;

            // Print the result of 13 added to 22
            int a = number0 + number1;
            Console.WriteLine(a);

            // Print the result of 13 substracted from 22
            int b = number1 - number0;
            Console.WriteLine(b);

            // Print the result of 22 mutiplied by 13
            int c = number0 * number1;
            Console.WriteLine(c);

            // Print the result of 22 divided by 13 (as a decimal fraction)
            double d = number1 / 13.0;
            Console.WriteLine(d);

            // Print the reminder of 22 divided by 13
            int e = number1 % number0;
            Console.WriteLine(e);

            // Print the integer part of 22 divided by 13
            int f = number1 / number0;
            Console.WriteLine(f);

            Console.ReadLine();
        }
    }
}
