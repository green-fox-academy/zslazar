using System;
using System.Collections.Generic;

namespace ListAscend
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 5, 4, 217, 34, 93, 17, 35, 31, 4, 129, 1, 55 };
            SortList(list);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }        

        static List<int> SortList(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i; j < list.Count - 1; j++)
                {
                    if (list[i] > list[j + 1])
                    {
                        int temp = list[i];
                        list[i] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
    }
}
