using System;

namespace _05_FleetOfThings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            //listahoz elemet hozzaad 1. modszer
            //Thing thing1 = new Thing("Milk");
            //fleet.Add(thing1);
            
            //listahoz elemet hozzaad egyik modszer
            //fleet.Add(new Thing("Get milk"));
            //fleet.Add(new Thing("Remove the obstacles"));
            //masik modszer

            var fleet = new Fleet();
            var thing0 = new Thing("Get milk");
            var thing1 = new Thing("Remove the obstacles");
            var thing2 = new Thing("Stand up");
            var thing3 = new Thing("Eat lunch");

            fleet.Add(thing0);
            fleet.Add(thing1);
            fleet.Add(thing2);
            fleet.Add(thing3);

            thing2.Complete();
            thing3.Complete();

            fleet.Printer();

            Console.ReadLine();

        }
    }
}
