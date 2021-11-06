using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationBankingSystem
{
    internal static class FinancialAccount
    {
        private static Account[] accountList = new Account[300];
        private static int count = 0;

        internal static void AddAccount(Account account)
        {
            accountList[count] = account;
            count++;

        }

        internal static void Show()
        {
            int index = 0;
            while (index < count)
            {
                accountList[index].AccountDetails();
                index++;

            }

        }
        internal static void SearchByName(string name)
        {
            bool accountFound = false;
            int index = 0;
            while (index < count)
            {
                if (accountList[index].Name.Equals(name))
                {
                    accountFound = true;
                    Console.WriteLine("ACCOUNT FOUND");
                    accountList[index].AccountDetails();
                    break;
                }
                index++;

            }
            if (!accountFound)
            {
                Console.WriteLine("ACCOUNT NOT FOUND");
            }
        }

        internal static bool SearchById(string id, out int place)
        {
            bool accountFound = false;
            place = -1;
            int index = 0;
            while (index < count)
            {
                if (accountList[index].Id.Equals(id))
                {
                    accountFound = true;
                    Console.WriteLine("ACCOUNT FOUND");
                    accountList[index].AccountDetails();
                    place = index;
                    return accountFound;
                }
                index++;

            }
            if (!accountFound)
            {
                Console.WriteLine("ACCOUNT NOT FOUND");

            }
            return accountFound;
        }
        internal static void Delete(string id)
        {
            int index;
            bool found = SearchById(id, out index);
            if (found)
            {
                accountList[index] = null;
                Console.WriteLine("ACCOUNT DELETE SUCCESFULLY");

            }
            else
                Console.WriteLine("ACCOUNT NOT EXIST");
         }

    }
}