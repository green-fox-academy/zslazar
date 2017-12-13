using System;

namespace Exercise22Again
{
    class Program
    {
        static void Main(string[] args)
        {
            // if a is even increment out by one
            double a = 24;
            int out1 = 0;
            //Out1(a, out1);
            int result = Out1(a, out1);
            Console.WriteLine(result);
            Console.ReadLine();
            
            int b = 13;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"

            if (10 < b && b < 20)
            {
                out2 = "Sweet";
            }
            if (b < 10)
            {
                out2 = "Less";
            }
            if (b > 20)
            {
                out2 = "More";
            }
            
            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if (credits >= 50 && isBonus == false)
            {
                c += 2;
            } 

            int d = 8;
            int time = 120;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            if (d % 4 == 0 && time <= 200)
            {
                out3 = "check";
            }
            else if (time > 200)
            {
                out3 = "TIme out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }
        }

        //methods
        static int Out1(double a, int out1)
        {
            if (a % 2 == 0)
            {
                return out1 += 1;
            }
            return out1;
        }
    }
}
