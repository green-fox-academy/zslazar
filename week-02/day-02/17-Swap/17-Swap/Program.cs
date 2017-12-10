using System;

namespace _17_Swap
{
    class Program
    {
        // - Create an array variable named `abc`
        //   with the following content: `["first", "second", "third"]`
        // - Swap the first and the third element of `abc`
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };
            string swap = abc[0];
            abc[0] = abc[2];
            abc[2] = abc[0];

            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }

            Console.ReadLine();

        }
    }
}
