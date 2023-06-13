using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DP
{
    // Observer
    public interface IBankAccountObserver
    {
        void Notify(string message);
    }
    public class BankAppObserver : IBankAccountObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"BankAppObserver received notification: {message}");
        }
    }
}
