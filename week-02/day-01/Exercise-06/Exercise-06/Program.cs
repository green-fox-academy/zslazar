using System;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //5*6/52

            int code = 6;
            int week = 17;
         
            int value = 5 * code * week;
            
            Console.WriteLine("workhours sum: " + value);

            // Print the percentage of the coding hours in the semester if the average work hours weekly is 52
            //6*5/52*100

            int workhour = 52;

            Console.WriteLine("percentage: " + (double)code * 5 / 52 * 100);

            Console.ReadLine();
        }
    }
}
