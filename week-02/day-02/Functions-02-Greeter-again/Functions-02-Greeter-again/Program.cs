using System;

namespace Functions_02_Greeter_again
{
    class Program
    {

        // - Create a string variable named `al` and assign the value `Greenfox` to it
        // - Create a function called `greet` that greets it's input parameter
        // - Greeting is printing e.g. `Greetings dear, Greenfox`
        // - Greet `al`

        public static void Greet()
        {
            string al = "Greenfox";
            Console.WriteLine("Greetings dear, " + al);

        }

        static void Main(string[] args)
        {
            Greet();
            Console.ReadLine();
        }
    }
}

