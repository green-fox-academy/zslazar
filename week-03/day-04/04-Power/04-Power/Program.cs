using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            int exponent = 6;
            Console.WriteLine(Power(number, exponent));
            Console.ReadLine();
        }

        static int Power(int number, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
            return Power(number, exponent - 1) * number;

            }
        }
    }
}