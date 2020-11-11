using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Account
    {
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string acid;

        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account() { }
        public Account(string accName, string acid, double balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("after depotist : " + amount + " your balance is : " + balance);
        }
        public void Withdraw(double amount)
        {
            balance = balance - amount;

            Console.WriteLine("after withdraw : " + amount + " your balace is : " + balance);
            if (balance < 0)
            {
                Console.WriteLine("sorry you have no amount in your account");
            }


        }
        public void Transfer(double amount, Account receiver)
        {
            if ( amount <= Balance)
            {
                this.Balance -= amount;
                receiver.Balance += amount;
                 
            }
            

        }
    }
}
