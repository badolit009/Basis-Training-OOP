using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        public string Number { set; get; }
        public string CustomerName { set; get; }
        public double Balance { private set; get; }
        public Account(string number,string customerName):this()
        {
            Number = number;
            CustomerName = customerName;
        }
        public Account()
        {
            Balance = 0;
        }
        public virtual string Withdraw ( double amount)
        {
            Balance -= amount;
            return "Whthdraw success";
        }
        public virtual string Deposit(double amount)
        {
            Balance += amount;
            return "Deposit success";

        }
    }
}
