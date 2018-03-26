using System;

namespace MixedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a function that takes two arrays and mixes them like this: [1, 2, 3] 
            and [6, 7, 8] becomes [1, 6, 2, 7, 3, 8]*/
            
            int[] array1 = new int[] { 1, 2, 3, };
            int[] array2 = new int[] { 6, 7, 8, };
            foreach (int i in Mix(array1, array2))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static int[] Mix(int[] array1, int[] array2)
        {
            int arrayLength = 2 * array1.Length;
            int[] mixedArray = new int[arrayLength];
            int x = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                mixedArray[x++] = array1[i];
                mixedArray[x++] = array2[i];
            }
            return mixedArray;
        }
    }
}
