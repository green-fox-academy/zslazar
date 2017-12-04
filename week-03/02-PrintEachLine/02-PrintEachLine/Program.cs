using System;
using System.IO;

namespace _02_PrintEachLine
{
    class Program

    // Write a program that opens a file called "my-file.txt", then prints
    // each of lines form the file. - File.ReadAllLines
    // If the program is unable to read the file (for example it does not exists),
    // then it should print an error message like: "Unable to read file: my-file.txt"

    {
        public static void Main(string[] args)
        {
            string path = @"c:\greenfox\zslazar\week-03\my-file.txt";

            try
            {
                string[] content = File.ReadAllLines(path);
                foreach (string line in content)
                    Console.WriteLine(line);
            }
                                   
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }

            Console.ReadLine();
        }
    }
}