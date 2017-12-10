using System;

namespace _19_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // -Create an array variable named `aj` with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };
            Array.Reverse(aj);
            for (int i = 0; i < aj.Length; i++)
            {
                Console.Write(aj[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
