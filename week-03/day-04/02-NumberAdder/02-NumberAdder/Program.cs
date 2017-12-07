using System;

namespace _02_NumberAdder
{
    // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Adder(input));
            Console.ReadLine();
        }

        public static int Adder(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + Adder(n - 1);
            }
        }

    }
}
