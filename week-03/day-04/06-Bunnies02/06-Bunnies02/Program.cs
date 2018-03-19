using System;

namespace _06_Bunnies02
{
    // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
    // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
    // have 3 ears, because they each have a raised foot. Recursively return the
    // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

    class Program
    {
        static void Main(string[] args)
        {
            int ear = 2;
            int freakEar = ear + 1;
            int bunnies = 8;
            Console.WriteLine(CountEar(bunnies, ear, freakEar));
            Console.ReadLine();
        }

        public static int CountEar(int bunnies, int ear, int freakEar)
        {
            if (bunnies == 0)
            {
                return 0;
            }
            else if (bunnies == 1)
            {
                return ear;
            }
            else
            {
                return ear + freakEar + CountEar(bunnies - 2, ear, freakEar);
            }
            
        }
    }
}