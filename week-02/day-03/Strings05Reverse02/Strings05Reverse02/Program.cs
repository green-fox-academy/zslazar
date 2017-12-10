using System;

namespace Strings05Reverse02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that can reverse a String, which is passed as the parameter
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
                 
            char[] reversedarray = reversed.ToCharArray();
            Array.Reverse(reversedarray);
            string output = new string(reversedarray);

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
