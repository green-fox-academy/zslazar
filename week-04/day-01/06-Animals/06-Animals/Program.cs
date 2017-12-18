using System;

namespace _06_Animals
{
    class Program
    {
        static void Main(string[] args)
        {

            var bunny = new Animal(50, 50);

            Console.WriteLine("Hunger rate: " + bunny.Hunger);
            bunny.Eat();
            Console.WriteLine("New hunger rate: " + bunny.Hunger);
            Console.ReadLine();

            
            
        }
    }
}
