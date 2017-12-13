using System;
using System.Collections.Generic;

namespace Lists03AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add "a" to every string in the far list.
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            var newlist = new List<string>();

            for (int i = 0; i < far.Count; i++)
            {
                newlist.Add(far[i] + "a");
            }

            foreach (var member in newlist)
            {
                Console.WriteLine(member);
            }
            Console.ReadLine();
        }
    }
}
