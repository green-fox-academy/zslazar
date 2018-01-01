﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    //    needs water if its current water amount is less then 5
    //when watering it the flower can only absorb the 75% of the water
    //eg.watering with 10 the flower's amount of water should only increase with 7.5
    public class Flower : Plants
    {
        public Flower(double waterLevel, string color) : base(waterLevel, color)
        {
            Absorb = 0.75;
            Thirst = 5;
        }

    }
}
