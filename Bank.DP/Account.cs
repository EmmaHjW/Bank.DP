using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DP
{
    // Factory Method
    public interface IAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    public class SavingsAccount : IAccount
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Depositing {amount} to savings account");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawing {amount} from savings account");
        }
    }

    public class CheckingAccount : IAccount
    {
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Depositing {amount} to checking account");
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrawing {amount} from checking account");
        }
    }
}
