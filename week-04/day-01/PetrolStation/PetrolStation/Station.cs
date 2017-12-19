using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    // Station
    // GasAmount
    // Refill(car) -> decreases the gasAmount by the capacity of the car 
    // and increases the cars gasAmount

    class Station
    {
        public int GasAmount { get; set; }

        public void Refill(Car c)
        {
            c.GasAmount++;
            c.Capacity--;
        }
    }
}
