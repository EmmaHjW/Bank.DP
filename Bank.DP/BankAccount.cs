using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DP
{
    public class BankAccount
    {
        private List<IBankAccountObserver> _observers = new List<IBankAccountObserver>();

        public void Subscribe(IBankAccountObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IBankAccountObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(message);
            }
        }
    }
}
