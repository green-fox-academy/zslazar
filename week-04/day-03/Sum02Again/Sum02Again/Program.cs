using System;
using System.Collections.Generic;


namespace Sum02Again
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public static int Sum()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(4);
            list.Add(4);

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
