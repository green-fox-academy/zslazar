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
            string path = @"C:\greenfox\zslazar\week-05\Practice\text.txt";


            StreamReader sr = new StreamReader(path);
            string line = "a";
            //while (sr.ReadLine() != null)
            //{
            //    Console.WriteLine(sr);
            //}

            while (line != null)
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
            }
            //StreamReader sr = new StreamReader(path);
            //Console.WriteLine(sr.ReadLine());



            Console.ReadLine();
        }
        //public Remover()
        //{

        //}
    }
}
