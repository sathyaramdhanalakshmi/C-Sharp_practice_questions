using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practiceques
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    class Car : Vehicle
    {
        public Car(string brand, int speed) : base(brand, speed) { }
    }

    class Bike : Vehicle
    {
        public Bike(string brand, int speed) : base(brand, speed) { }
    }

}
