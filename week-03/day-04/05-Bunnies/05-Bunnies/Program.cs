using System;

namespace _05_Bunnies
{
    // We have a number of bunnies and each bunny has two big floppy ears.
    // We want to compute the total number of ears across all the bunnies 
    // recursively (without loops or multiplication).

    class Program
    {
        static void Main(string[] args)
        {
            int ear = 2;
            int bunnies = 8;
            Console.WriteLine(CountEar(bunnies, ear));
            Console.ReadLine();
        }

        public static int CountEar(int bunnies, int ear)
        {
            if (bunnies == 0)
            {
                return 0;
            }
            else
            {
                return ear + CountEar(ear, bunnies - 1);
            }
        }
    }
}
