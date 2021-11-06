using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationBankingSystem
{
    internal class Current : Account
    {
        internal Current(string name, string id, DateFormat openingDate, AddressFormat address, double balance)
            : base(name, id, openingDate, address, balance)
        {

        }
        internal override string Id
        {

            set { this.id = "AC-" + value; }
        }
        internal override void AccountDetails()
        {
            Console.WriteLine("CURRENT ACCOUNT");
            base.AccountDetails();
        }
        internal void Deposit(double amount)
        {
            double balance;
            balance = this.Balance;
            if (amount >= 500)
            {
                balance = balance + amount;
                this.Balance = balance;
                Console.WriteLine("AFTER DEPOSIT BALANCE IS  : {0}", this.Balance);
            }
            else
                Console.WriteLine("YOUR DEPOSIT BALANCE MUST HAVE 500 TAKA OR ABOVE");
        }
        internal void Withdraw(double amonut)
        {
            double balance;
            balance = this.Balance;
            balance = balance - amonut;
            if (balance > 0)
            {
                if (amonut <= 5000)
                {
                        this.Balance = balance;
                        Console.WriteLine("AFTER WITHDRAW BALANCE IS :{0}", this.Balance);
                }
                else
                    Console.WriteLine("ABOVE 5000 TAKA TRANSACTION NOT ALLOWED");

            }
            else
                Console.WriteLine("YOUR ACCOUNT HAVE EMPTY BALANCE");

        }
    }
}
