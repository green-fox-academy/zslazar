using System;

namespace Functions_05_Factorial
{
    class Program
    // - Create a function called `factorio`
    //   that returns it's input's factorial
    {
        public static void Factorio(int input)
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("give me a number");
            int input = int.Parse(Console.ReadLine());
            Factorio(input);

            Console.ReadLine();
        }
    }
}
