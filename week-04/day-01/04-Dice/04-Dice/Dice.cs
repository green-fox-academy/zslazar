using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Dice
{
    //You have a Dice class which has 6 dice
    //You can roll all of them with Roll()
    //Check the current rolled numbers with GetCurrent()
    //You can reroll with Reroll()
    //Your task is to get where all dice is a 6
    class Dice
    {
        public int valaue;
        Random random = new Random();

        public int GetCurrent()
        {
            return valaue;
        }

        public void Roll()
        {
            valaue = random.Next(1, 7);
        }

        public void ReRoll()
        {
            valaue = random.Next(1, 7);
        }

    }
}