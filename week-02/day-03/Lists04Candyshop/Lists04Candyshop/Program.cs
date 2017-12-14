using System;
using System.Collections.Generic;

namespace Lists04Candyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            list.RemoveAt(1);
            list.Insert(1, "Croissant");
            list.Remove(false);
            list.Add("Ice cream");

            foreach (string elements in list)
            {
                Console.WriteLine(elements);
            }
                Console.ReadLine();
        }
    }
}
