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
        //first solution
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

        //second solution - t0bb sort csak t0bbszori futtatasra szed ki
        //{
        //    string characters = "//";

        //    string[] lines = File.ReadAllLines(path);
        //    List<string> linesList = new List<string>(lines);

        //    for (int i = 0; i < linesList.Count; i++)
        //    {
        //        if (linesList[i].Contains(characters))
        //        {
        //            linesList.RemoveAt(i);
        //        }
        //    }

        //    string[] linesArray = linesList.ToArray();
        //    File.WriteAllLines(path, linesArray);
        //    foreach (var arrayElements in linesArray)
        //    {
        //        Console.WriteLine(arrayElements);
        //    }
        //}

    }
}
