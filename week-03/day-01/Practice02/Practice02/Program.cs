using System;
using System.IO;
using System.Text;


namespace Practice02
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 0;

            string number = "500";

            double num = int.Parse(number);


            
            try
            {
                Console.WriteLine(a / b);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
        //sajat kiveteluyenet letrehozasa
        //public class MyException : Exception
        //{
        //    public MyException
        //        {
        //        Console.WriteLine("Please ezt ne");
        //        }


        
    }
}
