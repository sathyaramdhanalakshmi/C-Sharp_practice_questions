using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practiceques
{
    public class Vehicle1
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle1(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
    public class Car1 : Vehicle1
    {
        public Car1(string brand, int speed) : base(brand, speed) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a car.");
        }
    }

    public class Bike1 : Vehicle1
    {
        public Bike1(string brand, int speed) : base(brand, speed) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a bike.");
        }
    }
}
