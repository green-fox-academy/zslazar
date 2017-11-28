using System;

namespace Example
{
    class Program

    // - Create a string variable named `am` and assign the value `kuty` to it
    // - Write a function called `appendA` that gets a string as an input
    //   and appends an 'a' character to its end
    
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            appendA(am);
        }

    // - Print the result of `appendA(am)`

        static void appendA(string adda)
        {
            Console.WriteLine(adda + "a");
            Console.ReadLine();
        }
    }
}
