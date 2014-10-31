using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings :Account
    {
        public double InterestAmount { set; get; }
        public Savings(string number, string customerName, double interestAmount) : base(number, customerName)
        {
            InterestAmount = interestAmount;
        }

        public override string Withdraw(double amount)
        {
            if (Balance-amount>=0)
            {
                return base.Withdraw(amount);  
            }
            else
            {
                return "Insifficent Balance";
            }
        }
    }
}
