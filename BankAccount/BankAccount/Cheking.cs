using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Cheking : Account
    {

        public double ServiceCharge { set; get; }
        public int NoOfTransition { set; get; }

        public Cheking(string number, string customerName, double serviceCharge) : base(number, customerName)
        {
            ServiceCharge = serviceCharge;

        }

        public override string Deposit(double amount)
        {
            NoOfTransition++;
            return base.Deposit(amount);
        }

        public override string Withdraw(double amount)
        {
            NoOfTransition++;
            return base.Withdraw(amount);
        }
    }
}
