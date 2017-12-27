using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

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
            DeleteComments(path);
        }

        static void DeleteComments(string path)
        {
            var streamWriter = new StreamWriter(path);
            List<string> lines = File.ReadAllLines(path).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Trim().Length < 2)
                    streamWriter.WriteLine(lines[i]);
                else if (lines[i].Trim().Substring(0, 2) != "//")
                    streamWriter.WriteLine(lines[i]);
            }
            streamWriter.Close();
        }

    }
}
