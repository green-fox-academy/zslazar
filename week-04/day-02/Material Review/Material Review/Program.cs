using System;
using System.Collections.Generic;

namespace Material_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            var carList = new List<Car>();
            //var car = new Car();
            var trabi = new Trabi(25);
            Console.WriteLine(trabi.Color);
            Console.ReadLine();

            Car car0;
            Car car1;
            Trabi car2;
            car0 = trabi;
            car1 = new Audi("ahoj");
            car0.SayHello();
            carList.Add(car0);
            carList.Add(car1);
            carList.Add(car2);

            foreach (var car in carList)
            {
                car.SayHello();
            }
        }

    }
}
