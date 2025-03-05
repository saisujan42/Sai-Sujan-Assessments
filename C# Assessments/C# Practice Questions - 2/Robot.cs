using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment2
{
    public interface Movable
    {
        void Move();
    }

    public class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine started.");
        }
    }

    public class Robot : Machine, Movable
    {
        public void Move()
        {
            Start();
            Console.WriteLine("Robot is moving.");
        }
    }
}
