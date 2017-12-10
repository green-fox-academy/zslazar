using System;

namespace _11_DiagonalMatrix
{
    class Program
    {
        //Create(dynamically) a two dimensional array with the following matrix. Use a loop!
        //
        //   1 0 0 0
        //   0 1 0 0
        //   0 0 1 0
        //   0 0 0 1
        //
        // - Print this two dimensional array to the output
        // GetLength(0) returns the number of elements in the first dimension of the Array
        static void Main(string[] args)
        {
            int[,] matrix = new int [4,4]
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 1, 0},
                { 0, 0, 0, 1}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                        Console.Write(matrix[i, j] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
