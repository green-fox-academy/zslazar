using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs the farmer has

            Console.WriteLine("Howdy, number of chickens?");
            string chicken = Console.ReadLine();
            int chickenleg = int.Parse(chicken);

            Console.WriteLine("Nice, and number of pigs?");
            string pig = Console.ReadLine();
            int pigleg = int.Parse(pig);

            //megjeleníti most csak a 2 értéket egymás mellett, először szozoztassuk össze

            int chlegs = chickenleg * 2;
            int plegs = pigleg * 4;

            int allegs = chlegs + plegs;

            Console.WriteLine("legs: " + allegs);

            Console.ReadLine();

            // It should print how many legs all the animals have
        }
    }
}