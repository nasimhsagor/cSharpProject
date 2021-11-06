using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationBankingSystem
{
    internal class Loan : Account
    {

        internal Loan(string name, string id, DateFormat openingDate, AddressFormat address, double balance)
            : base(name, id, openingDate, address, balance)
        {

        }
        internal override string Id
        {

            set { this.id = "AL-" + value; }
        }
        internal override void AccountDetails()
        {
            Console.WriteLine("LOAN ACCOUNT");
            base.AccountDetails();
        }
        internal void Deposit(double amount)
        {
            double balance;
            balance = this.Balance;
            balance = balance + amount;
            this.Balance = balance;
            Console.WriteLine("AFTER DEPOSIT BALANCE IS : {0}", this.Balance);

        }
        internal void Withdraw(double amonut)
        {
            double balance;
            balance = this.Balance;
            balance = balance - amonut;
            if (balance > 0)
            {
                
                    this.Balance = balance;
                    Console.WriteLine("CURRENT BALANCE :{0}", this.Balance);
            }
            else
                Console.WriteLine("YOUR ACCOUNT HAVE EMPTY BALANCE");

        }

    }
}
