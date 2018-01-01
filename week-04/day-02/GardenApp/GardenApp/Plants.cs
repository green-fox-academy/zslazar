using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    public class Plants
    {
        //magaba foglalja a flowert meg a treet
        public double WaterLevel { get; set; }
        public double Absorb { get; set; }
        public string Color { get; set; }
        public double Thirst { get; set; }

        public Plants(double waterLevel, string color)
        {
            WaterLevel = waterLevel;
            Color = color;
        }

        public void GetWater(double waterAmount)
        {
            WaterLevel = WaterLevel + waterAmount * Absorb;
        }

    }
}
