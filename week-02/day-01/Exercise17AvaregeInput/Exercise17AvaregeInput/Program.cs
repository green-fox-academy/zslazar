using System;

namespace Exercise17AvaregeInput
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Give me the first number");
            string first = Console.ReadLine();
            int firstn = int.Parse(first);

            Console.WriteLine("Give me the second number");
            string second = Console.ReadLine();
            int secondn = int.Parse(second);

            Console.WriteLine("Give me the third number");
            string third = Console.ReadLine();
            int thirdn = int.Parse(third);

            Console.WriteLine("Give me the fourth number");
            string fourth = Console.ReadLine();
            int fourthn = int.Parse(fourth);

            Console.WriteLine("Give me the fifth number");
            string fifth = Console.ReadLine();
            int fifthn = int.Parse(fifth);

            int sum = firstn + secondn + thirdn + fourthn + fifthn;
            int average = sum / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            Console.ReadLine();

        }
    }
}
