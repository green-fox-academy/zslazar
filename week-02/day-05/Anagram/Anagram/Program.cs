using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "listen";
            string input2 = "silent";
            CheckAnagram(input1, input2);
            Console.ReadLine();
        }

        public static void CheckAnagram(string input1, string input2)
        {
            char[] array1 = input1.ToCharArray();
            char[] array2 = input2.ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);

            string sorted1 = new string(array1);
            string sorted2 = new string(array2);

            if (sorted1 == sorted2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not anagram");
            }
        }
    }
}
