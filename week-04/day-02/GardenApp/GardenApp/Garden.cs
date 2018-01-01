using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{    
    //garden feladata: locsoljon
    public class Garden
    {
        //is able to hold unlimited amount of flowers or trees --list!! a kertet feltoltjuk novenyekkel de ez meg ures
        public List<Plants> FlowerTree = new List<Plants>();

        //igy adunk hozza uj egyedeket - A listát feltöltjük a plant objektum elemeivel - de lehet siman a program.cs-ben is x.FlowerTree.Add methoddal
        public void Planting(Plants plants)
        {
            FlowerTree.Add(plants);
        }

        public void Watering(double water)
        {
            double thirstPlants = 0;
            double waterAmount = 0;

            //ha locsol kiirja mennyivel
            if (water != 0)
            {
                Console.WriteLine("Watering with {0}", water);
            }
            
            //szomjas-e vagy sem
            foreach (var plant in FlowerTree)
            {
                if (plant.WaterLevel < plant.Thirst)
                {
                    Console.WriteLine("The {0} needs water", plant.Color);
                    thirstPlants++;
                }
                else
                {
                    Console.WriteLine("The {0} doesn't need water", plant.Color);
                }
            }

            //when watering it should only water those what needs water with equally divided amount amongst them
            //eg.watering with 40 and 4 of them need water then each gets watered with 10

            if (thirstPlants != 0);
            {
                waterAmount = water / thirstPlants;

                foreach (var plant in FlowerTree)
                {
                    if (plant.WaterLevel < plant.Thirst)
                    {
                        plant.GetWater(waterAmount);
                    }
                }

            }
        }
    }
}
