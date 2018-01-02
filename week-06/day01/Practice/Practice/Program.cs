using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Move(100);
            Console.WriteLine(car.distanceTaken);

            IMoveable something = new Car();
            something.Move(200);
            Console.WriteLine(((Car)something).distanceTaken);

            Console.ReadLine();
        }
    }
}
