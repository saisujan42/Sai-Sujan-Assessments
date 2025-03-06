using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment3
{
    public interface Vehicle
    {
        void Start();
        void TopSpeed();
    }

    public class Car : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is Starting...");
        }

        public void TopSpeed()
        {
            Console.WriteLine("Car Top Speed is 200 km/hr");
        }
    }

    public class Bike : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike is Starting...");
        }
        public void TopSpeed()
        {
            Console.WriteLine("Bike Top Speed is 120 km/hr");
        }
    }
}
