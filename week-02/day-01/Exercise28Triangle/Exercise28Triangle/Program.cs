using System;

namespace Exercise28Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            int number = int.Parse(Console.ReadLine());
            string star = "*";
            

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }
            Console.ReadLine();
        }
    }
}
