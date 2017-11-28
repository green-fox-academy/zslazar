using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)

        // - Write a function called `sum` that sum all the numbers
        //   until the given parameter
        //1. egy szamot beolvastatni !szamkent
        //2. return - osszeadani 0tol az adott szamig

        //Console.WriteLine();
        //Console.ReadLine();
        {

            //keri az erteket es kezeli szamkent
            Console.WriteLine("give me a number");
            string number = Console.ReadLine();
            int addnumber = int.Parse(number);
            
            //az eredmeny megjelenitese
            Console.WriteLine(Sum(addnumber));
            Console.ReadLine();
        }
            //a muvelet definialasa
        static int Sum(int num)
        {
            return (num * (num + 1)) / 2;
        }

        }
}