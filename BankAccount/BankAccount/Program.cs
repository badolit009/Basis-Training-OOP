using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings sa1 = new Savings("001","Faez",9000);
            sa1.Deposit(1000);
            sa1.Withdraw(200);
            sa1.Deposit(4000);
            Console.WriteLine(sa1.Balance);
            
            Cheking cha1 = new Cheking("001","Moshiur",4000);
            cha1.Deposit(6000);
            cha1.Withdraw(5000);
            Console.WriteLine(cha1.NoOfTransition);

            Savings sa2 = new Savings("004", "Morshed", 6000);
            sa2.Deposit(8000);
            sa2.Withdraw(3000);

            List<Account> anAccounts = new List<Account>();
            anAccounts.Add(sa1);
            anAccounts.Add(cha1);
            anAccounts.Add(sa2);
            GetAllAccount(anAccounts);
            Console.ReadKey();
        }
        private static void GetAllAccount(List<Account> anAccounts)
        {
            foreach (Account anAccount in anAccounts)
            {
                Console.WriteLine(anAccount.Withdraw(100) +" "+anAccount.Balance);
            }
        }
    }
}
