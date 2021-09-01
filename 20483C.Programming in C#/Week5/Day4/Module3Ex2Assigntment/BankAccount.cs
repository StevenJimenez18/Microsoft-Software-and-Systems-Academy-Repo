using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Ex2
{
    public delegate void BalanceCheck(double balance);
    enum AccountType
    {
        Checking=1, Saving
    }
    class BankAccount
    {
        public StringBuilder AccountNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AccountType AccountType { get; set; }

        private double balance;
        public event BalanceCheck LowBalance;
        public double _balance
        {
            get { return this.balance; }
            set
            {
                if(value < 200)
                {
                    LowBalance(value);
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public BankAccount()
        {

        }

        public BankAccount (string fname, string lname, AccountType accountType, double balance)
        {

            this.AccountNumber = GetAccountNumber();
            this.FirstName = fname;
            this.LastName = lname;
            this.AccountType = accountType;
            this.balance = balance;
        }

        public static StringBuilder GetAccountNumber() {
 
            StringBuilder sb = new StringBuilder();

            Random rand = new Random();
            for(int i = 0; i < 7; i++)
            {
                sb.Append(rand.Next(1, 9));
            }
            return sb;
        }
    }
}
