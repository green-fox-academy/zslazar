using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // make it bigger by 10
            int a = 3;
            a += 10;

            Console.WriteLine(a);

            // make it smaller by 7
            int b = 100;
            b -= 7;
            Console.WriteLine(b);

            // please double c's value
            int c = 44;
            c *= 2;
            Console.WriteLine(c);

            // with itself
            int x = 44;
            x *= x;
            Console.WriteLine(x);

            // please divide by 5 d's value
            int d = 125;
            d /= 5;
            Console.WriteLine(d);

            // please cube of e's value
            // double value5 = Math.Pow(2, 3);??
            double e = 8;

            //solution1
            //e = e * e * e;

            //solution2
            e = Math.Pow(e, 3);
            Console.WriteLine(e);

            // tell if f1 is bigger than f2 (print as a boolean)
            int f1 = 123;
            int f2 = 345;
           
            if (f1 > f2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            {











                Console.ReadLine();
            }
        }
    }
}