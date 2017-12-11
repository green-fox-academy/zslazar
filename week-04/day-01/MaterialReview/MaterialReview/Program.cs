using System;
using System.Collections.Generic;

namespace MaterialReview
{
    //ha van vmi egyedi tipusunk akkor azt structban lehet definialni ilyen kis primitiv tipusokat
    struct SuchPoint
    {
        public int X;
        public int Y;
        public int Z;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //példányosítás - new értékkel létehozás 
            //var tree = new Tree();
            //tree.Height = 10;
            

            //Console.WriteLine(tree.Height);
            var tree = new Tree(6);
            var treeList = new List<Tree>();

            for (int i = 0; i < 10; i++)
            {
                treeList.Add(new Tree("Name", i));
            }

            treeList[2].Height = 70;
            treeList[2].Id = "70";


            Cake.Cheesecake
        }
    }
}
