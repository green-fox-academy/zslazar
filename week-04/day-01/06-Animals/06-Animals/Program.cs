using System;

namespace _06_Animals
{
    class Program
    {
        static void Main(string[] args)
        {

            var animal01= new Animal();

            Console.WriteLine("Hunger rate: " + animal01.Hunger);
            animal01.Eat();
            Console.WriteLine("New hunger rate: " + animal01.Hunger);
            Console.ReadLine();

            
        }
    }
}
