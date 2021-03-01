using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Address address1 = new Address("4","319A","Dhaka","Bangladesh");
            //Account account1 = new Account(1001, "Shakib", 2000, address1);
            //account1.PrintAccount();
            
            Bank myBank = new Bank("Developer's bank", 5);
            myBank.AddAccount (new Account(1001, "Shakib", 2000, new Address("4", "319A", "Dhaka", "Bangladesh")));
            myBank.AddAccount(new Account(1002, "Sabrina", 3000, new Address("5", "56", "Dhaka", "Bangladesh")));
            myBank.AddAccount(new Account(2001, "Shakil", 5000, new Address("4", "20", "Chittagong", "Bangladesh")));
            myBank.DeleteAccount(1001);
            myBank.PrintAllAccounts();

        }
    }
}
