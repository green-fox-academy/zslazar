using System;

namespace _10_ChangeElement
{
    class Program
    {
        // - Create an array variable named `s` with the following content: `[1, 2, 3, 8, 5, 6]`
        // - Change the 8 to 4
        // - Print the fourth element
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 8, 5, 6 };
            s[3] = 4;
            Console.WriteLine(s[3]);
            Console.ReadLine();
        }
    }
}
