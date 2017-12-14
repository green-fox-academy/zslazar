using System;
using System.Collections.Generic;

namespace Lists07IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?
            //// Search for this element. - if (list.Contains("dog")) { Console.WriteLine("dog was found");}
            //solution 1
            var newlist = new List<int> { 4, 8, 12, 16 };
            bool result = true;

            for (int i = 0; i < newlist.Count; i++)
            {
                if (list.Contains(newlist[i]))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    i = newlist.Count - 1;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();

            //solution2
            //var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            //var checkList = new List<int> { 4, 8, 12, 16 };
            //bool containsAll = true;
            //foreach (int item in checkList)
            //{
            //    // or check list.IndexOf return value 
            //    if (!list.Contains(item))
            //    {
            //        containsAll = false;
            //    }
            //}
            //Console.WriteLine(" 'list' contains all the elements of 'checkList': " + containsAll);
            //Console.ReadLine();


        }
    }
}
