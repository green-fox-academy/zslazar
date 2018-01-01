using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public class Program
    {
        //in your main method you should create a garden with flowers and trees
        //The program should demonstrate an example garden
        //two flowers(yellow and blue)
        //two trees(purple and orange)
        //after creating them you should show the user, how the garden looks like
        //After that the program should water the garden twice
        //first with the amount of 40 then with 70
        //after every watering the user should see the state of the garden

        static void Main(string[] args)
        {
            //var flowerone = new Flower(4, "pink");
            //newgarden.FlowerTree.Add(flowerone);
            //vagy newgarden.FlowerTree.Add(new Flower(5, "yellow"));
            //vagy newgarden.Planting(new Flower(4, "yellow flower"));

            Garden newgarden = new Garden();

            newgarden.Planting(new Flower(4, "yellow flower"));
            newgarden.Planting(new Flower(4, "blue flower"));
            newgarden.Planting(new Tree(7, "purple tree"));
            newgarden.Planting(new Tree(7, "orange tree"));
            

            newgarden.Watering(0);
            Console.WriteLine();

            newgarden.Watering(40);
            Console.WriteLine();

            newgarden.Watering(70);
            
            Console.ReadLine();
        }

    }
  
}



