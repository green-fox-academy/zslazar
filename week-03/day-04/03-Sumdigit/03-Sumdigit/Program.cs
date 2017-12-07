using System;

namespace _03_Sumdigit
{
    // Given a non-negative int n, return the sum of its digits recursively (no loops). 
    // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
    // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(input));
            Console.ReadLine();
        }

        public static int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return (n % 10) + Sum(n / 10);
            }
        }

    }
}