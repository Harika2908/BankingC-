using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace ConsoleApp4.MyCode
{

    class Class1
    {
        
        static void Main(String[] args)
        {
            //create the checking account with initial balance
            CheckingAcct checking = new CheckingAcct("john", "Doe", 2500.0m);
            //create the checking account with interest and initial balance
            SavingsAcct Saving = new SavingsAcct("Hari", "Doddi", 0.025m,1000.0m);
            //check the balances in checking and savings account
            Console.WriteLine($"checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {Saving.Balance:C2}");

            //print the account owner information
            Console.WriteLine($"checking account owner is :{checking.AccountOwner}");
            Console.WriteLine($"Savings account owner is :{Saving.AccountOwner}");

            //Deposit some money in each account
            checking.Deposit(200.0m);
            Saving.Deposit(150.0m);

            //check the balances in checking and savings account
            Console.WriteLine($"checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {Saving.Balance:C2}");

            //make some withdrawls from the account
            checking.WithDraw(50.0m);
            Saving.WithDraw(125.0m);

            //check the balances in checking and savings account
            Console.WriteLine($"checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {Saving.Balance:C2}");

            //Apply the savings interst
            Saving.ApplyInterest();
            Console.WriteLine($"Savings balance is {Saving.Balance:C2}");
            //more than 3 withdrawls should result in charge
            Saving.WithDraw(10.0m);
            Saving.WithDraw(20.0m);
            Saving.WithDraw(30.0m);
            Console.WriteLine($"Savings balance is {Saving.Balance:C2}");
            //try to overdraw checking results in extra charge
            checking.WithDraw(3000);
            Console.WriteLine($"checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {Saving.Balance:C2}");
        }
    }
}
