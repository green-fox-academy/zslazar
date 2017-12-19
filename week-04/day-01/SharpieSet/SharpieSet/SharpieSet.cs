using System;
using System.Collections.Generic;
using System.Text;

namespace SharpieSet
{
    // Create SharpieSet class
    // it contains a list of Sharpie
    // Add method CountUsable() -> sharpie is usable if it has ink in it
    // Add method RemoveTrash() -> removes all unusable sharpies

    class SharpieSet
    {
        //private List<Sharpie> sharpies;
        public List<Sharpie> Sharpies { get; set; }

        public SharpieSet()
        {
            Sharpies = new List<Sharpie>();
        }

        public int CountUsable()
        {
            int counter = 0;
            for (int i = 0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].InkAmount > 0)
                {
                    counter++;
                }
            }
            return counter;

        }

        public int RemoveTrash()
        {
            int counter = 0;
            for (int i = 0; i < Sharpies.Count; i++)
            {
                if (Sharpies[i].InkAmount == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
