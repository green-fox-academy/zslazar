using System;
using System.Collections.Generic;
using System.Text;

namespace Material_Review
{
    class Trabi : Car
    {
        public int Age { get; set; } = 25;
        public Trabi(int age) : base("Yeay") //a parent konstruktor hivasa
        {
            Age = age;
            Console.WriteLine("Hello Trabi!");
            //Console.WriteLine(ECU);
            Console.WriteLine();
            SayHello();
        }
        //igy erheto el a protected masik classban levo, kiscsaladon belul latszik
        public string GetECU ()
        {
            return ECU;
        }

        public override void SayHello()
        {
            Console.WriteLine("hello ccar");
        }
    }
}
