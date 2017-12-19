using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet

{
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
