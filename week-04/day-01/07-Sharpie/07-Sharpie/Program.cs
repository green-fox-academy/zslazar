using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {

            var sharpie = new Sharpie("Black", 6);
            sharpie.Use();
            sharpie.Use();

            Console.WriteLine(sharpie.InkAmount);
            Console.ReadLine();
        }
    }
}
