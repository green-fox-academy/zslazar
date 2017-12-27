using System;
using System.IO;
using System.Linq;

namespace ExamDeleteTheComments
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Create a function that (1)takes a c# source file path (e.g. "src.cs") as an input, 
           (2)reads the given file, and (3)remove the single line comments from it. It should write the comment-free */
            // code to the original file. (e.g. this line of comment is single lined, the one above not)
            //  Console.WriteLine();
            string path = @"C:\greenfox\zslazar\week-05\Practice\Program.cs";

            Reader(path);
            Console.ReadLine();
        }
        
        public static void Reader(string path)
            {
            StreamReader sr = new StreamReader(path);
           
            while (sr.Peek() >= 0)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }

    }
}
