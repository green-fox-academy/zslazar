using System;
using System.Collections.Generic;

namespace SharpieSet
{
    class Program
    {
    // Sharpie Set
    // Reuse your Sharpie class
    // Create SharpieSet class
    // it contains a list of Sharpie
    // Add method CountUsable() -> sharpie is usable if it has ink in it
    // Add method RemoveTrash() -> removes all unusable sharpies

        static void Main(string[] args)
        {
            var first = new Sharpie("Black", 6);
            var second = new Sharpie("White", 7);
            first.Use();
            second.Use();
                      
                        
            //Console.WriteLine(second.InkAmount);
                                  
            var newlist = new SharpieSet();
            //newlist.Sharpies.Add(new Sharpie("White", 4));
            newlist.Sharpies.Add(first);
            newlist.Sharpies.Add(second);
                            
                                               
            Console.WriteLine(newlist.CountUsable());
            //Console.WriteLine(newlist.RemoveTrash());
            Console.ReadLine();

        }
    }
}

