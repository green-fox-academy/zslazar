using System;

namespace Matrix
{
    class Program
    {
        private const int size = 3;
        static void Main(string[] args)
        {
            var matrix = new int[size, size];
            //szimmetrikus matrixnal gyokot kell vonni h mekapjuk a hanyszor hanyas a matrix

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = i + j;
                }
             
            }
        }

        public static int[,] Invert(int[,] matrix)
        {
            //zarojelbe teszed - atkasztolod
            //int[,] invertedMatrix = new int[size, size];
            int[,] invertedMatrix = (int[,])matrix.Clone();
            
            return new int[0,0];
        }
    }
}
