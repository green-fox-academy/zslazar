using System;

namespace Exercise08Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // a 2 ertek
            int a = 123;
            int b = 526;

            // uj valtozo hozzaadva
            int c;

            // ertekek felcserelese
            c = a;
            a = b;
            b = c;

            // ertekek kiirasa
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
