using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.MyCode
{
    class SavingsAcct : BankAccount
    {
        private int _WithDrawCount = 0;
        private const decimal _WithDrawCharge = 2.0m;
        private const int WithDraw_Limit = 3;
        public SavingsAcct(string fname, string lname, decimal interest, decimal initial) : base(fname, lname, initial)
        {
            InterestRate = interest;
        }
        public decimal InterestRate { get; set; }
        public void ApplyInterest()
        {
            //add new amount to the existing balance
            Balance = Balance + Balance * InterestRate;
        }
        public override void WithDraw(decimal amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("Attempt to overDraw--denail");
            }
            else
            {
                base.WithDraw(amount);
                _WithDrawCount++;
                //charge for more than 3 withdraws.
                if(_WithDrawCount > WithDraw_Limit)
                {
                    Console.WriteLine("more than 3 withdraws--extra charge");
                    base.WithDraw(_WithDrawCharge);
                }
            }
        }


    }
}