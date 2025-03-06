using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment3
{
    class Animal2
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog2 : Animal2
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
