using System;

namespace _01_PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1;
            postIt1.BackgroundColor = "orange";
            postIt1.TextColor = "blue";
            postIt1.Text = "Idea 1";

            PostIt postIt2;
            postIt2.BackgroundColor = "pink";
            postIt2.TextColor = "black";
            postIt2.Text = "Awesome";

            PostIt postIt3;
            postIt3.BackgroundColor = "yellow";
            postIt3.TextColor = "green";
            postIt3.Text = "Superb";
            
            Console.WriteLine();
        }
    }
}
