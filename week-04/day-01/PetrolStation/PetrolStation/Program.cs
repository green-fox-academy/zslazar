using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var station = new Station();

            //vagy itt allitok be neki kulon erteket
            //car.GasAmount = 9;
            //car.Capacity = 20;

            //vagy itt az alapertekeket hasznalom
            station.Refill(car);


            Console.WriteLine($"Capacity: {car.Capacity}, Gasamount: {car.GasAmount}");
            Console.WriteLine("Capacity: {0}, Gasamount: {1}", car.Capacity, car.GasAmount);
            Console.ReadLine();
        }
        
    }
}
