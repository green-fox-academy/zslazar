using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Apples
{
    public class Apples
    {
        private string message;

        public Apples(string message)
        {
            this.message = message;
        }

        public string PrintMessage()
        {
            Console.WriteLine(message);
            return message;
        }
    }
}
