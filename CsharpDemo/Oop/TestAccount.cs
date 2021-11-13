using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.Oop
{
    enum AccountType { SAVINGS, CURRENT };

    class Account
    {
        private int acno;
        private string ahname;
        private int balance;
        private AccountType type = AccountType.SAVINGS;
        private static int minbal = 10000;

        public Account(int acno, string ahname)
        {
            this.acno = acno;
            this.ahname = ahname;
        }

        public void Deposit(int amount)
        {
            this.balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (this.balance - Account.minbal >= amount)
                this.balance -= amount;
            else
                throw new ArgumentException("Insufficient Funds");
        }

        public int GetBalance()
        {
            return this.balance;
        }

        public static int GetMinBal()
        {
            return Account.minbal;
        }

        // Read-only Property 
        public int Number
        {
            get
            {
                return this.acno;
            }
            set
            {
                this.acno = value;
            }
        }
    }
    class TestAccount
    {
        static void Main(string[] args)
        {
            var a1 = new Account(1, "Joe");
            a1.Deposit(100000);
            a1.Withdraw(50000);
            Console.WriteLine(a1.GetBalance());

        }
    }
}
