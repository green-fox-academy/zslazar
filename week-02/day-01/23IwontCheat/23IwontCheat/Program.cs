using System;

namespace _23IwontCheat
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            string text = "I won't cheat on the exam!";
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i + ". " + text);
            }

            Console.ReadLine();
        }
    }
}
