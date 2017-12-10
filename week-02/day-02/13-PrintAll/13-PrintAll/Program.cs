using System;

namespace _13_PrintAll
{
    class Program
    {
        // - Create an array variable named `af`
        //   with the following content: `[4, 5, 6, 7]`
        // - Print all the elements of `af`
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };
            for (int i = 0; i < af.Length; i++)
                Console.WriteLine(af[i]);
                Console.ReadLine();
        }
    }
}
