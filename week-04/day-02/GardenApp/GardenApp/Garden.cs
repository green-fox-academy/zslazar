using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    //    is able to hold unlimited amount of flowers or trees
    //when watering it should only water those what needs water with equally divided amount amongst them
    //eg.watering with 40 and 4 of them need water then each gets watered with 10
    //locsoljon
    public class Garden
    {
        public List<Plants> FlowerTree { get; set; }

        public Garden()
        {
            FlowerTree = new List<Plants>();
        }


        public void Adding()
        {
           
        }
    }
}
