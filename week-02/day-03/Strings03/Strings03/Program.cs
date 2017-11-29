using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            ////Hofstadter's Law: It always takes longer than you expect, even when you take into account Hofstadter's Law.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            //quote = quote.Insert(21, "always takes longer than ");

            //split string
            string start = quote.Substring(0, 20);
            string add = "always takes longer than ";
            string end = quote.Substring(21);

            //build new line
            StringBuilder newquote = new StringBuilder();
                newquote.Append(start);
                newquote.Append(add);
                newquote.Append(end);
            
            Console.WriteLine(newquote);
            Console.ReadLine();
        }
    }
}
