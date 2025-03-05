using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }
        public Manager Manager { get; set; }

        public Department(string departmentName, Manager manager)
        {
            DepartmentName = departmentName;
            Manager = manager;
        }
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        public Department DeepCopy()
        {
            return new Department(DepartmentName, new Manager(Manager.Name));
        }
    }
}
