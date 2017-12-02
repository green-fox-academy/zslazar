using System;

namespace Example
{
    class Program
    {
            //a muvelet definialasa
        static int Sum(int num)
        {
            return (num * (num + 1)) / 2;
        }

        static void Main(string[] args)

        // - Write a function called `sum` that sum all the numbers
        //   until the given parameter
        
        {
            //keri az erteket es kezeli szamkent
            Console.WriteLine("give me a number");
            int addnumber = int.Parse(Console.ReadLine());
            
            //az eredmeny megjelenitese
            Console.WriteLine(Sum(addnumber));
            Console.ReadLine();
        }

    }
}