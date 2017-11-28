using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[7];
            numbers[0] = 7;
            numbers[1] = 8;
            numbers[2] = 9;
            numbers[3] = 13;
            numbers[4] = 10;

            //ez a 2 ugyanaz

            // int[] numbers = { 7, 8, 9, 13, 10 };

            Console.WriteLine(numbers[3]);
            printMyFavouriteNumbers();
            Greet("Tojas");
            bool isSevenEven = IsEven(7);
            Console.WriteLine(isSevenEven);
        }

        static void printMyFavouriteNumbers()
        {
            Console.WriteLine(42);
            Console.WriteLine(8);
            Console.WriteLine(100);

            
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }




    }
}
