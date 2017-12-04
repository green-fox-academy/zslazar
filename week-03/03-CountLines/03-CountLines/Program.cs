using System;
using System.IO;

namespace CountLines
{
    class Program

    // Write a function that takes a filename as string,
    // then returns the number of lines the file contains.
    // It should return zero if it can't open the file, and
    // should not raise any error.

    {
        static void Main(string[] args)
        {

            Console.WriteLine("give me the filename");

            try
            {
                string number = Console.ReadLine();
                Counter(number);
                Console.WriteLine(number);
            }
            catch (Exception)
            {

                Console.WriteLine("0");
            }
            Console.ReadKey();

        }

        static void Counter(string count)
        {
            //beolvastatom a tartalmat
            string[] lenght = File.ReadAllLines(count);
            //meghatarozom a tartalom hosszat
            int number = lenght.Length;
            //kiirtom a kapott eredmenyt
            Console.WriteLine(number);

        }
    }
}