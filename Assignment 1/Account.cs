using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public void PrintAccount()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.address.PrintAddress();
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }

        public void Transfer(double amount)
        {
            if (amount < balance)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("Invalid balance");
            }
        }
        public void Receiver(double amount)
        {
            balance = balance + amount;
        }
        void ShowAccountInformation()
        {
            Console.WriteLine("AccountNumber: " + accountNumber);
            Console.WriteLine("AccountName: " + accountName);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Address: " + address);
        }


    }
}
