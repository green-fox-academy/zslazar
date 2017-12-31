using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    public class Plants
    {
        public int WaterAmount { get; set; }
        public double Absorb { get; set; }
        public string Color { get; set; }
        public double Thirst { get; set; }
        //magaba foglalja a flowert meg a treet

        public Plants(int waterAmount, double absorb, string color)
        {
            WaterAmount = waterAmount;
            Absorb = absorb;
            Color = color;
        }

        
    }
}
