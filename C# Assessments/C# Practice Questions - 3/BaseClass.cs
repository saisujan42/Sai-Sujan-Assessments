using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment3
{
    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("This is Base Class.");
        }
    }

    class DerivedClass : BaseClass
    {
        public void Display()
        {
            Console.WriteLine("This is Derived Class.");
        }
    }
}
