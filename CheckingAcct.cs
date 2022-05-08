using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.MyCode
{
      class CheckingAcct : BankAccount
    {
        //constant value
        private const decimal OverDraw_Charge = 35.0m;
        //inheriting properties of the parent class bankAccount
        public CheckingAcct(string fname, string lname, decimal initial) 
            : base(fname, lname, initial)
        {
        }
        //override fn for the virtual fn written in parental class
        public override void WithDraw(decimal amount)
        {
            //if the account gets overdrawn apply charges
            if (amount > Balance)
            {
                Console.WriteLine("tried to withdraw more than balance--extra charges");
                
            }
            base.WithDraw(OverDraw_Charge);
        }
       

    }
}
