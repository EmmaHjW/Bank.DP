using System.Security.Principal;

namespace Bank.DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factory Method
            IAccountFactory accountFactory;

            Console.WriteLine("Enter 1 for Savings Account or 2 for Checking Account:");
            int accountType = int.Parse(Console.ReadLine());

            if (accountType == 1)
            {
                accountFactory = new SavingsAccountFactory();
            }
            else if (accountType == 2)
            {
                accountFactory = new CheckingAccountFactory();
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting...");
                return;
            }

            IAccount account = accountFactory.CreateAccount();

            // Singleton
            BankService bankService = BankService.Instance;
            bankService.PerformTransaction(account, 1000);

            // Observer
            BankAccount bankAccount = new BankAccount();
            IBankAccountObserver observer = new BankAppObserver();
            bankAccount.Subscribe(observer);

            bankAccount.NotifyObservers("New transaction: $1000 deposited to your account.");

            bankAccount.Unsubscribe(observer);

            bankAccount.NotifyObservers("This message won't be received by the observer anymore.");
        }
    }
}