using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Bank
    {
        private string name;
        private Account[] accounts;
        public Bank(string name, int size)
        {
            this.name = name;
            accounts = new Account[size];
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public Account[] Accounts
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }

        public void PrintAllAccounts()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].PrintAccount();
            }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(int accountNo)
        {
            
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNo)
                {
                    accounts[i] = null;
                    for (int j = i; j < accounts.Length; j++)
                    {
                        if (j < accounts.Length - 1)
                        {
                            accounts[j] = null;
                            accounts[j] = accounts[j + 1];
                        }
                        else
                        {
                            accounts[j] = null;

                        }
                    }
                    Console.WriteLine("Account Deleted");
                    break;
                }
            }
                
        }
    }
}
