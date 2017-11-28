using System;

namespace Functions_02_Greeter
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            
            string al = "Greenfox";
            Greet(al);
        }

        //- Greeting is printing e.g. `Greetings dear, Greenfox`
        //- Greet `al`

        static void Greet(string al)
        {
            Console.WriteLine("Greeting dear, " + al);
            Console.ReadLine();
        }
    }
}
