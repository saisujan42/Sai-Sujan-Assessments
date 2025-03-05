using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment2
{
    public class Employee
    {
        public string? Name { get; set; }
        public double Salary { get; set; }

        public Employee(string Name, double Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }

    public class Manager : Employee
    {
        public double Bonus { get; set; }
        public Manager(string Name, double Salary, double Bonus) : base(Name, Salary)
        {
            this.Bonus = Bonus;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Manager Details : ");
            Console.WriteLine($"Name: {Name}, Salary: {Salary}, Bonus: {Bonus}");
        }
    }
}