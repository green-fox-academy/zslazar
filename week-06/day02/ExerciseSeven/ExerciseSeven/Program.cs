using System;
using System.Linq;

namespace ExerciseSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            
            //solution1
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                                "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var theCity = cities.Where(n => n[0] == 'A' && n.Last() == 'I');

            foreach (var element in theCity)
            Console.WriteLine(element);

            //solution2
            cities.Where(x => x.StartsWith("A") && x.EndsWith("I"))
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            Console.ReadLine();
        }
    }
}
