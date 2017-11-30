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

            //solution 1
            //double mxh = massInKg / heightInM;
            //Console.WriteLine(mxh / heightInM);

            //solution2
            double BMI = massInKg / Math.Pow(heightInM, 2);

            Console.WriteLine("BMI index is " + BMI);
            Console.ReadLine();
        }
    }
}