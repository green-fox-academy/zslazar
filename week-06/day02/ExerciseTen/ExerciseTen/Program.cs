using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseTen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a Fox class with 3 properties(name, type, color) 
            Fill a list with at least 5 foxes, it's up to you how you name/create them! 
            Write a LINQ Expression to find the foxes with green color! 
            Write a LINQ Expression to find the foxes with green color and asbest type!*/

            //vagy kulon adogatom hozza
            //foxList.Add(new Fox("Vuk", "corsac", "red"));

            List<Fox> foxList = new List<Fox>()
            {
                new Fox("Vuk", "please", "red"),
                new Fox("Karak", "asbest", "green"),
                new Fox("Kag", "please", "green"),
                new Fox("Íny", "asbest", "blue"),
                new Fox("Sut", "badcat", "black")
            };

            foxList.Where(x => x.Color == "green")
                .ToList()
                .ForEach(x => Console.WriteLine(x.Name));

            foxList.Where(f => f.Color == "green" && f.Type == "asbest")
                .ToList()
                .ForEach(f => Console.WriteLine(f.Name));

            Console.ReadLine();
        }
    }
}
