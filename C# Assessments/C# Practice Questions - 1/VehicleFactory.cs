using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    public interface Vehicle2
    {
        public void Drive();
    }

    public class Car2 : Vehicle2
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    public class Bike2 : Vehicle2
    {
        public void Drive()
        {
            Console.WriteLine("Bike is driving...");    
        }
    }
    class VehicleFactory
    {
        public Vehicle2 GetVehicle(string VehicleType)
        {
            switch(VehicleType.ToLower())
            {
                case "car":
                    return new Car2();
                case "bike":
                    return new Bike2();
                default:
                    return null;
            }
        }
    }
}
