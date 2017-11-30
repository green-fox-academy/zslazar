using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 17;
            int n = 5;
            int o = 6;

            int s = (h * n * o) / h;

            int av = 52;

            double p = ((double)o * n / av) * 100;

            Console.WriteLine("percentage: " + p);

            Console.ReadLine();
        }
    }
}