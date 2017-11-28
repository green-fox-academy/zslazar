using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values = weight/height
            double massInKg = 81.2;
            double heightInM = 1.78;

            double mxh = massInKg / heightInM;

            Console.WriteLine(mxh / heightInM);

            Console.ReadLine();
        }
    }
}