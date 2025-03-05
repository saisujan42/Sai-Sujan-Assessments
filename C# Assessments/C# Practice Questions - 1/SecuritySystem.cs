using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    sealed class SecuritySystem
    {
        public SecuritySystem() { }

        public void Activate()
        {
            Console.WriteLine("Security System Activated.");
        }
    }

    /*
    class HomeSecurity : SecuritySystem
    {
        public HomeSecurity() { }
        public void Activate()
        {
            Console.WriteLine("Home Security System Activated.");
        }
    }*/
}
