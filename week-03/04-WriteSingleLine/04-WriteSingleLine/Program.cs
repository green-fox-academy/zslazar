using System;
using System.IO;
using System.Text;

namespace _04_WriteSingleLine
{
    class Program
    // Open a file called "my-file.txt"
    // Write your name in it as a single line
    // If the program is unable to write the file,
    // then it should print an error message like: "Unable to write file: my-file.txt"


    {
        static void Main(string[] args)
        {
            string path = @"c:\greenfox\zslazar\week-03\my-file.txt";
            using (StreamWriter writer = new StreamWriter(path))
            try
                {
                string name = "Zsuzsa Lazar";
                writer.WriteLine(name);
                }

            catch
                {
                    string errormsg = "Unable to write file: my-file.txt";
                    Console.WriteLine(errormsg);
                }

                finally
                {
                    Console.ReadLine();
                }
        }
    }
}
