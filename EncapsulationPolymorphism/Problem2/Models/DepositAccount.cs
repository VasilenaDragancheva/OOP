using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.Enums;

namespace Problem2.Models
{
    public class DepositAccount : Account
    {
        public DepositAccount(string customerID,CustomerType customerType, decimal balance, decimal interest)
            : base(customerID,customerType, balance, interest)
        {

        }
        public override decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value > 0)
                {
                    throw new ArgumentOutOfRangeException("Deposit balance is not possitve!");
                }
                this.balance = value;
            }
        }
        public override decimal CalculateInterest()
        {
            decimal calculatedRate = 0;
            if (this.Balance > 1000)
            {
                calculatedRate = this.Balance*(1+  this.Interest * this.MonthsFromStartDate());
             
            }
            return calculatedRate;
        }

    }
}

