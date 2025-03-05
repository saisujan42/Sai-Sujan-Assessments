using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment2
{
    class Vehicle
    {
        public string? Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string? brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
        }
    }

    class Car : Vehicle
    {
        public int Wheels { get; set; }

        public Car(string? brand, int speed, int wheels) : base(brand, speed)
        {
            Wheels = wheels;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Wheels: {Wheels}");
        }
    }

    class Bike : Vehicle
    {
        public int Gears { get; set; }

        public Bike(string? brand, int speed, int gears) : base(brand, speed)
        {
            Gears = gears;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Gears: {Gears}");
        }
    }
}