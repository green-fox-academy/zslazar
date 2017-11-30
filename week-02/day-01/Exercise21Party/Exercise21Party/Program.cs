using System;

namespace Exercise21Party
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
                       
            
            Console.WriteLine("girls?");
            int girls = int.Parse(Console.ReadLine());

            Console.WriteLine("boys?");
            int boys = int.Parse(Console.ReadLine());

            //int people = girls + boys;

            // If the the number of girls and boys are equal and there are more people coming than 20
            // It should print: The party is exellent!

            // If no girls are coming, regardless the count of the people
            // It should print: Sausage party

            if (girls == 0)
            {
                Console.WriteLine("Sausage party");
            }


            else if ((girls == boys) && ((girls + boys) > 20))
            {
                Console.WriteLine("The party is exellent!");
            }

            // If there are more than 20 people coming but the girl - boy ratio is not 1-1
            // It should print: Quite cool party!

            else if ((girls != boys) && (girls + boys > 20))
            {
                Console.WriteLine("Quite cool party!");
            }

            // If there are less people coming than 20
            // It should print: Average party...

            else if ((girls + boys) < 20)
            {
                Console.WriteLine("Average party...");
            }

            
            else
                {
                Console.WriteLine();
                }

            Console.ReadLine();
        }
    }
}
