using System;
using System.Collections.Generic;
using System.Text;

namespace Material_Review
{
    class Car
    {
        //ez igy egy kezdoerteket ad neki, de lehetne konstruktorral is
        public string Color { get; set; } = "Green";
        protected string ECU { get; set; } = "SuchECU";

        //itt a konstruktor = string text 1. ugyanaz a neve mint a classnak 2 nem void vagy int 3 eloszor ez fut le
        public Car(string text)
        {
            Console.WriteLine("Hello Car!");
            Console.WriteLine(text);
        }

        public virtual void SayHello()
        {
            Console.WriteLine("hello carr");
        }

    }
}
