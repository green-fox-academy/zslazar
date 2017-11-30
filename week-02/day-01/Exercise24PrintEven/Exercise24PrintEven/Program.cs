using System;

namespace Exercise24PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500

            //solution 1
            // for (int i = 1; i < 251; i++)
            //
            //     Console.WriteLine(i*2);
            // Console.ReadLine();

            //solution 2
            //int i = 0;
            //while (i < 500)
            //{
            //    i += 2;
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //solution 3
            
            for (int i = 0; i <= 500; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
                       


        }
    }
}
