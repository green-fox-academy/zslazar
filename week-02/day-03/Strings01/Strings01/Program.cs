using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleReplace
{
    public class SimpleReplace
    {
        public static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            //Console.WriteLine(sampleString1.Replace("some","apple"));

            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            //first solution
            //Console.WriteLine(example.Replace("dishwasher", "galaxy"));

            //second solution
            example = example.Replace("dishwasher", "galaxy");
            Console.WriteLine(example);
            Console.ReadLine();
        }
    }
}