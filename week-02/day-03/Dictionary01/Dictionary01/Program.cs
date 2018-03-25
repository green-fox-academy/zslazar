﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Things are a little bit messed up
            // Your job is to decode the notSoCrypticMessage by using the hashmap as a look up table
            // Assemble the fragments into the out variable

            string output = "";
            int[] notSoCrypticMessage = { 1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11 };

            var map = new Dictionary<int, string>();

            map.Add(7, "run around and desert you");
            map.Add(50, "tell a lie and hurt you ");
            map.Add(49, "make you cry, ");
            map.Add(2, "let you down");
            map.Add(12, "give you up, ");
            map.Add(1, "Never gonna ");
            map.Add(11, "\n");
            map.Add(3, "say goodbye ");

            // put segments into a stringbuilder 
            var builder = new StringBuilder();
            for (int i = 0; i < notSoCrypticMessage.Length; i++)
            {
                builder.Append(map[notSoCrypticMessage[i]] + "\n");
            }

            output = builder.ToString();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}