using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account[] a = new Account[1];
           // a[0] = new Savings("NASIM","0001",new DateFormat(6,2,2021),new AddressFormat(58,2,"DHAKA","BANGLADESH"),25000);

            Savings AS0001 = new Savings("NASIM", "0001", new DateFormat(6, 2, 2021), new AddressFormat(58, 2, "DHAKA", "BANGLADESH"), 25000);
            Savings AS0002 = new Savings("JINNAT", "0002", new DateFormat(7, 2, 2021), new AddressFormat(7, 3, "DHAKA", "BANGLADESH"), 30000);
           // AS0001.AccountDetails();
           // AS0001.Deposit(2000);
           // AS0001.AccountDetails();
            AS0001.Withdraw(1000);
            AS0001.AccountDetails();

           /* AS0002.AccountDetails();
            AS0002.Deposit(1500);
            AS0002.AccountDetails();
            AS0002.Withdraw(500);
            AS0002.AccountDetails();
            */
            FinancialAccount.AddAccount(new Savings("NASIM", "0001", new DateFormat(6, 2, 2021), new AddressFormat(58, 2, "DHAKA", "BANGLADESH"), 25000));
           // FinancialAccount.Show();
            // FinancialAccount.SearchName("NASIM");
           // FinancialAccount.SearchById("AS-OOO1");
           // FinancialAccount.Delete("AS-0002");
           // FinancialAccount.Show();

        }
    }
}