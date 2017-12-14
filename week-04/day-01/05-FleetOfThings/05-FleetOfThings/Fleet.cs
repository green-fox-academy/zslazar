using System;
using System.Collections.Generic;


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

        public void Printer()
        {
            for (int i = 0; i < Things.Count; i++)
            {
                if (Things[i].GetCompleted())
                {
                    Console.WriteLine(i + 1 + "." + " [x] " + Things[i].GetName());
                }
                else
                {
                    Console.WriteLine(i + 1 + "." + " [ ] " + Things[i].GetName());
                }
            }
        }
    }
}
