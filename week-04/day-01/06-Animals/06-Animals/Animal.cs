using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Animals
{
    class Animal
    {
        public int Hunger { get; set; }
        public int Thirst { get; set; }

        public Animal(int hunger, int thirst)
        {
            Hunger = hunger;
            Thirst = thirst;
        }

        public void Eat()
        {
            Hunger -= 1;
        }

        public void Drink()
        {

            Thirst -= 1;
        }

        public void Play()
        {
            Hunger += 1;
            Thirst += 1;
        }
    }
}