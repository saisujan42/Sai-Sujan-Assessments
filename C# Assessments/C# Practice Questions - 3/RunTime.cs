using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment3
{
    public class RunTime
    {
        public virtual void MakePayment(double Amount)
        {
            Console.WriteLine("Payment made: " + Amount);
        }
    }

    public class CreditCardPayment : RunTime
    {
        public override void MakePayment(double Amount)
        {
            Console.WriteLine("Credit Card Payment made: " + Amount);
        }
    }

    public class UPIPayment : RunTime
    {
        public override void MakePayment(double Amount)
        {
            Console.WriteLine("UPI Payment made: " + Amount);
        }
    }
}
