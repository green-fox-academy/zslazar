using System;

namespace _14_DoubleItems
{
    class Program
    {
        // - Create an array variable named `ag`
        //   with the following content: `[3, 4, 5, 6, 7]`
        // - Double all the values in the array
        static void Main(string[] args)
        {
            int[] ag = { 3, 4, 5, 6, 7 };
            for (int i = 0; i < ag.Length; i++)
            {
                //solution1
                ag[i] = ag[i] * 2;
                //solution2
                //ag[i] = ag[i] + ag[i];
                Console.WriteLine(ag[i]); 
            }
            Console.ReadLine();
        }
    }
}
