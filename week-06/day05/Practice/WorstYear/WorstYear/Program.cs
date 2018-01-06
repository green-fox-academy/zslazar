using System;
using System.IO;

namespace WorstYear
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./100worst.csv";
            string[] lines = File.ReadAllLines("./100worst.csv");
        
        }

        public static string[] ReadLines(string path)
        {
            try
            {
                return File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new string[0];
        }

        public static string[][] SplitLines(string[] lines)
        {
            string[][] splitLines = new string[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                splitLines[i] = lines[i].Split(";");
            }
            return splitLines;
        }
    }
}
