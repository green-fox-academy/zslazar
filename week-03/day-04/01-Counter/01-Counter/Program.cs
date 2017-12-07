using System;

namespace _01_Counter
{
    // Write a recursive function that takes one parameter: n and counts down from n.
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Counter(a);
            Console.ReadLine();
        }

        public static int Counter(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                return Counter(n - 1);
            }
            else
            {
                return n;
            }
        }
    }
}
