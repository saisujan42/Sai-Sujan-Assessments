using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment3
{
    abstract class Vehicle2
    {
        public abstract void Start();
        public abstract void TopSpeed();

        public void Stop()
        {
            Console.WriteLine("Vehicle is Stopping...");
        }
    }

    class Car2 : Vehicle2
    {
        public override void Start()
        {
            Console.WriteLine("Car is Starting...");
        }
        public override void TopSpeed()
        {
            Console.WriteLine("Car Top Speed is 200 km/hr");
        }
    }

    class Bike2 : Vehicle2
    {
        public override void Start()
        {
            Console.WriteLine("Bike is Starting...");
        }
        public override void TopSpeed()
        {
            Console.WriteLine("Bike Top Speed is 150 km/hr");
        }
    }
}
