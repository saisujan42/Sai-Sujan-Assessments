using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment2
{
    sealed class SecuritySystem
    {
        public string PinCode = "1234";
        public SecuritySystem()
        {
            Console.WriteLine("Security System Activated.");
        }

        public void AuthenticateUser()
        {
            Console.Write("Enter Your PinCode: ");
            string UserInput = Console.ReadLine();
            if (UserInput != null && PinCode == UserInput)
                Console.WriteLine("Authentication Successful.");
            else
                Console.WriteLine("Wrong Password");
        }
    }

    public class HomeSecuritySystem : SecuritySystem
    {
        public HomeSecuritySystem()
        {
            Console.WriteLine("Home Security System Activated.");
        }

        public void AuthenticateUser()
        {
            Console.WriteLine("Authentication Successful");
        }
    }
}
