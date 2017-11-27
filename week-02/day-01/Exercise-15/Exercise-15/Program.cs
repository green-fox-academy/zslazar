using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("Hello user what is the distance in kilometers?");
            string datakm = Console.ReadLine();
            int datam = int.Parse(datakm);
             
            Console.WriteLine("In miles it is: " + datam * 0.621);

            Console.ReadLine();

        }
    }
}