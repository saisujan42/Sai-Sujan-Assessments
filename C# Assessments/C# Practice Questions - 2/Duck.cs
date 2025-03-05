using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment2
{
    public interface Flyable
    {
        void Fly();
    }

    public interface Swimmable
    {
        void Swim();
    }
    public class Duck : Flyable, Swimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }
        public void Swim()
        {
            Console.WriteLine("Duck is swimming");
        }
    }
}
