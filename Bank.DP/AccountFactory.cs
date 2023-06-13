using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DP
{
    public interface IAccountFactory
    {
        IAccount CreateAccount();
    }

    public class SavingsAccountFactory : IAccountFactory
    {
        public IAccount CreateAccount()
        {
            return new SavingsAccount();
        }
    }

    public class CheckingAccountFactory : IAccountFactory
    {
        public IAccount CreateAccount()
        {
            return new CheckingAccount();
        }
    }

}
