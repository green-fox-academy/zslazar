using System;

namespace Exercise29Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            int number = int.Parse(Console.ReadLine());
            string star = "*";
            int i;
            int j;



            for (i = 0; i < number; i++)
            {
                for (j = i; j < number - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(star);
                star += "**";
            }

            Console.ReadKey();
        }

    }
}
