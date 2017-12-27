using System;
using System.IO;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //beolvassa a tartalmat
            //string[] array = File.ReadAllLines(@"C:\greenfox\zslazar\week-03\text.txt");

            //foreach (string line in array)
            //{
            //    Console.WriteLine(line);
            //}

            //Console.ReadLine();

            //vagy igy is lehet, eredmeny ugyanaz
            //string sometext = File.ReadAllText(@"C:\greenfox\zslazar\week-03\text.txt");
            //Console.WriteLine(sometext);
            //Console.ReadLine();


            //kiiratni a tartalmat
            //felulirja a bennelevot ha nem ures
            //File.WriteAllText(@"C:\greenfox\zslazar\week-03\text.txt", "Fifa is a good game");
            //Console.ReadLine();

            //string[] array = { "123", "EA" };
            //File.WriteAllText(@"C:\greenfox\zslazar\week-03\text.txt", array);

            //Console.ReadLine();

            //kiirja a fileban levo tartamat
            //StreamReader sr = new StreamReader(@"C:\greenfox\zslazar\week-03\text.txt");
            //string line = "";
            //while (line != null)
            //{
            //line = sr.ReadLine();
            //Console.WriteLine(line);
            //}

            //while (sr.ReadLine() != null)
            //{
            //    Console.WriteLine(sr);
            //}

            // hozzafuzi a meglevo tartalomhoz
            //StreamWriter sw = new StreamWriter(@"C:\greenfox\zslazar\week-03\text.txt", true);
            //string line1 = "Fifa";
            //sw.WriteLine(line1);
            ////
            //StreamWriter sw = new StreamWriter("TasksInText.txt", true);
            //string line = "Feed the monkey";
            //sw.WriteLine(line);
            //sw.Close();

            //StreamWriter sw = new StreamWriter(@"C:\greenfox\zslazar\week-03\text.txt");
            //string line1 = "Fifa";

            //sw.WriteLine(line1);

            //ugyanaz mint sw.Dispose(); csak dispose kitorli a memoriabol 
            //sw.Close(); --- .Close();!!! enelkul nem mukszik...

        }
    }
}

