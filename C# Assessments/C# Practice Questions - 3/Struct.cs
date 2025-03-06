using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment3
{
    public interface Struct
    {
        public void DIsplay()
        {
            Console.WriteLine("This is an Interface.");
        }
    }

    public struct Struct1 : Struct
    {
        public void Display()
        {
            Console.WriteLine("This is the First Struct.");
        }
    }

    public struct Struct2 : Struct
    {
        public void Display()
        {
            Console.WriteLine("This is the Second Struct");
        }
    }
}