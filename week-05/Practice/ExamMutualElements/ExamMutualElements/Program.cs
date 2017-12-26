using System;
using System.Collections.Generic;

namespace MutualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<int>() { 1, 1, 2, 3, 3, 4 };
            var secondList = new List<int>() { 3, 4, 4, 5, 6 };

            var mutualElements = FilterMutualElements(firstList, secondList);

            mutualElements.ForEach(i => Console.Write("{0}, ", i));
            Console.ReadLine();
        }

        public static List<int> FilterMutualElements(List<int> firstList, List<int> secondList)
        {
            List<int> commonList = new List<int>();

            foreach (int number in firstList)
                if (secondList.Contains(number) && !commonList.Contains(number))
                    commonList.Add(number);
            return commonList;
        }
    }
}