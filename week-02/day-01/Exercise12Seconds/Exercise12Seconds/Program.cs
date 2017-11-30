using System;

namespace Exercise12Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables

            int secondsnow = currentHours * 3600 + currentMinutes * 60 + currentSeconds;

            int allseconds = 86400;

            int remain = (allseconds - secondsnow);

            Console.WriteLine("Remain: " + remain + " seconds");
            Console.ReadLine();
        }
    }
}
