using System;
using System.Collections.Generic;
using System.Text;

namespace MaterialReview
{
    class Tree
    {
        //private - védve van az osztályon belül
        //get - bekéri az értéket
        //property - van get set

        //konstruktor: objektumhoz tartozo eslo metodus ami lefut, egyer fut le a legelejen
        //this. - sajat magara hivatkozik a classon belul
        public Tree(string name, int value, int duck)
        {
            private int duck; 

            this.duck = duck;
            Name = "Fa";
            Leaf = value;
            Console.WriteLine(this.);
        }

        public int Leaf { get; set; }
        public int Height { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        public void Grow()
        {
            Height++;
        }


        //public void SetLeaf(int value)
        //{
        //    leaf = value;
        //}
        //ha private itt adok meg neki erteket, sajat osztalyon belul latszik csak    
        //public void SetLeaf(int value)
        //{
        //    Leaf = value;
        //}
    }
}
