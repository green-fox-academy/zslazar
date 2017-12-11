using System;
using System.Collections.Generic;
using System.Text;

namespace _05_FleetOfThings
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }
    }
}
