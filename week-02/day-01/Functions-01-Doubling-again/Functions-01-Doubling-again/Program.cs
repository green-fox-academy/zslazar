using System;

namespace Functions_01_Doubling_again
{
    class Program
    {
        // - Create an integer variable named `ak` and assign the value `123` to it
        // - Create a function called `doubling` that doubles it's input parameter
        // - Print the result of `doubling(ak)`

        public static void Doubling()
        {
            int ak = 123;
            Console.WriteLine(ak * 2);
        }

        static void Main(string[] args)
        {
            Doubling();
            Console.ReadLine();
        }
    }
}