using System;

namespace _05_FleetOfThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            //listahoz elemet hozzaad 1. modszer
            //Thing thing1 = new Thing("Milk");
            //fleet.Add(thing1);

            
            //listahoz elemet hozzaad 2 modszer
            fleet.Add(new Thing("Get milk"));
            fleet.Add(new Thing("Remove the obstacles"));
            fleet.Add(new Thing("Stand up"));
            fleet.Add(new Thing("Eat lunch"));


            

        }
    }
}
