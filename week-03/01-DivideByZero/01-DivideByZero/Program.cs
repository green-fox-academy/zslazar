using System;

namespace _01_DivideByZero
{
    class Program
    {
        // create a function that takes a number
        // divides ten with it,
        // and prints the result.
        // it should print "fail" if the parameter is 0

        public static int Divide(int number)
        {
            number = 10 / number;
            return number;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("give me a number");
            int number = int.Parse(Console.ReadLine());
            try
            {
                
                Console.WriteLine(Divide(number));
            }

            catch
            {
                Console.WriteLine("fail!");
            }
                        
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
