using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sharpie
{
    // We should know about each sharpie their Color(which should be a string), Width(which will be a floating point number), InkAmount(another floating point number)
    // When creating one, we need to specify the Color and the Width
    // Every sharpie is created with a default 100 as InkAmount
    // We can Use() the sharpie objects
    // which decreases inkAmount
    class Sharpie
    {
        public string Color { get; set; }
        public float Width { get; set; }
        public float InkAmount { get; set; }

        public Sharpie(string color, float width)
        {
            Color = color;
            Width = width;
            InkAmount = 100;
        }

        public void Use()
        {
            InkAmount -= 1;
        }
    }
}
