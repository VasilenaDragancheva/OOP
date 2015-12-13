using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Interfaces
{
    public interface IDepositAccount : IAccount, IDepositable
    {
        void WithdrawMoney(decimal amount);
    }
}
