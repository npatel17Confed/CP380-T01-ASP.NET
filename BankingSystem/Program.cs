using System;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;
            try
            {
                account = new BankAccount("Nilkumar Patel", 2000);
                Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Cannot create an account with negative initial balance.");
                Console.WriteLine(e.ToString());
                return;
            }
            try
            {
                account.MakeWithdrawal(200, DateTime.Now, "Rent payment");
                account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalid amount detected while performing the operation.");
                Console.WriteLine(e.ToString());
                return;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Cannot overdraw money from the account.");
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
