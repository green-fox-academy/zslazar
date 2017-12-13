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

            int result = Out1(a, out1);
            Console.WriteLine(result);
            Console.ReadLine();

            // if b is between 10 and 20 set out2 to "Sweet!", less than 10 "Less!",more than 20 "More!"
            int b = 13;
            string out2 = "";
            string result2 = Out2(b, out2);
            Console.WriteLine(result2);

            // if credits are at least 50, and isBonus is false decrement c by 2
            int c = 123;
            int credits = 100;
            bool isBonus = false;
            int result3 = Bonus(c, credits, isBonus);
            Console.WriteLine(result3);

            int d = 8;
            int time = 120;
            string out3 = "";
            string result4 = Out3(d, time, out3);
            Console.WriteLine(result4);

            Console.ReadLine();
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

        static string Out2(int b, string out2)
        {
            if (b < 10)
            {
                return out2 = "Less";
            }
            else if (b > 20)
            {
                return out2 = "More";
            }
            else
            {
                return out2 = "Sweet";
            }
        }

        static int Bonus(int c, int credits, bool isBonus)
        {
            if (isBonus == true)
            {
                return c;
            }
            else if (credits >= 50 && isBonus == false)
            {
                return c += 2;
            }
            return c += 1;
        }

        static string Out3(int d, int time, string out3)
        {
            // if d is dividable by 4 and time is not more than 200 set out3 to "check"
            // if time is more than 200 set out3 to "Time out", otherwise set out3 to "Run Forest Run!"

            if (d % 4 == 0 && time <= 200)
            {
                return out3 = "check";
            }
            else if (time > 200)
            {
                return out3 = "Time out";
            }
            else
            {
                return out3 = "Run Forest Run!";
            }
        }
    }
}

