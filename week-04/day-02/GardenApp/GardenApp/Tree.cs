using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    //    needs water if its current water amount is less then 10
    //when watering it the tree can only absorb the 40% of the water
    //eg.watering with 10 the tree's amount of water should only increase with 4
    public class Tree : Plants
    {
        public Tree() : base(0, 0.4, "color")
        {

        }
    }
}
