using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment2
{
    public class Account
    {
        public string? AccountNumber;
        public double Balance;

        public Account(string AccountNumber, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating Interest... ");
        }
    }

    public class SavingsAccount : Account
    {
        public double InterestRate;
        public SavingsAccount(string AccountNumber, double Balance, double InterestRate) : base(AccountNumber, Balance)
        {
            this.InterestRate = InterestRate;
        }
        public sealed override void CalculateInterest()
        {
            double Interest = Balance * InterestRate;
            Balance += Interest;
            Console.WriteLine("Calculated Interest : " + Interest);
            Console.WriteLine("Final Balance : " + Balance);
        }
    }
}
