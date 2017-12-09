using System;

namespace _06_PrintArguments
{
    class Program
    {
        // - Create a function called `printer`which prints the input String parameters
        // - It can have any number of parameters

        // Examples
        // printer("first")
        // printer("first", "second")
        // printer("first", "second", "third", "fourth")
        
        static void Main(string[] args)
        {
            string[] array = {"first", "second", "third", "fourth" };
            Printer(array);
            Console.ReadLine();
        }

        public static void Printer(string[] text)
        {                
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
