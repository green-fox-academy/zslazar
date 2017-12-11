using System;
using System.Collections.Generic;

namespace _04_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dices = new List<Dice>();
            //letrehozok 6 kockat
            for (int i = 0; i < 6; i++)
            {
                dices.Add(new Dice());
            }
            //megporgetem
            for (int j = 0; j < 6; j++)
            {
                dices[j].Roll();
                while (dices[j].GetCurrent() != 0 )
                {
                    dices[j].ReRoll();
                }
                Console.WriteLine(dices[j].GetCurrent());
            }
            Console.ReadLine();                  

        }
    }
}