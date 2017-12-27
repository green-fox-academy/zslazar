using System;

namespace _01_DivideByZero
{
    class Program
    {

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
