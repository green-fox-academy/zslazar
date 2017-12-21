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
            Garden newgarden = new Garden();
            newgarden.FlowerTree.Add(new Flower("yellow"));
            newgarden.FlowerTree.Add(new Flower("blue"));
            newgarden.FlowerTree.Add(new Tree("purple"));
            newgarden.FlowerTree.Add(new Tree("orange"));

            //var flowerone = new Flower("yellow");
            //newgarden.FlowerTree.Add(flowerone);
            

            Console.WriteLine();
            Console.ReadLine();
        }

    }
  
}



