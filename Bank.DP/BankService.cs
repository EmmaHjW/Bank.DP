using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DP
{
    // Singleton
    public class BankService
    {
        private static BankService _instance;
        private static readonly object _lock = new object();

        private BankService()
        {
            // Private constructor to prevent direct instantiation
        }

        public static BankService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new BankService();
                    }
                    return _instance;
                }
            }
        }

        public void PerformTransaction(IAccount account, decimal amount)
        {
            // Perform transaction logic
            Console.WriteLine($"Performing transaction on {account.GetType().Name} with amount {amount}");
        }
    }
}
