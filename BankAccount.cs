using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.MyCode
{
    class BankAccount // parental class
    {
        private string _FirstName;
        private string _LastName;
        public decimal Balance { get; set; }

        //Constructor
        public BankAccount(string fname, string lname, decimal initial = 0.0m)
        {
            _FirstName = fname;
            _LastName = lname;
            Balance = initial;
        }
        //AccountOwner = FirstName + LastName
        public string AccountOwner
        {
            get => $"{_FirstName} {_LastName}";
        }
        //depositing money in acccount
        public virtual void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }
        //withdraw money from the account
        public virtual void WithDraw(decimal amount)
        {
            Balance = Balance - amount;
        }
    }
}
