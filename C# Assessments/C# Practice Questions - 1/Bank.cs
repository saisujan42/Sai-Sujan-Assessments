using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class Bank
    {
        public static double InterestRate { get; private set; } = 5.0;
        public string AccountHolder { get; }

        public Bank(string accountHolder)
        {
            AccountHolder = accountHolder;
        }

        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Interest Rate: {InterestRate}%");
        }
    }
}