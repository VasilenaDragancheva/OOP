using System;
using System.Collections.Generic;
using Problem2.Interfaces;
using Problem2.Enums;
namespace Problem2.Models
{
    public class LoanAccount : Account, IDepositable
    {
        private const int Companies_Special_Rates = 2;
        private const int Individuals_Special_Rates = 3;

        public LoanAccount(string customerID, CustomerType customerType, decimal balance, decimal interest)
            : base(customerID, customerType, balance, interest)
        {

        }
        public override decimal Balance
        {
            get
            {
                return this.Balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance can not be negative!");
                }
                this.balance = value;
            }
        }
            
        public override decimal CalculateInterest()
        {
            decimal calculatedRate = 0;
            decimal rate = 0;
            if(this.CustomerType==CustomerType.Company)
            {
                rate = this.MonthsFromStartDate() > Companies_Special_Rates ? this.MonthsFromStartDate() -Companies_Special_Rates : 0;
                rate *= this.Interest;
               
            }
            else
            {
                rate = this.MonthsFromStartDate() > Individuals_Special_Rates ? this.MonthsFromStartDate() - Individuals_Special_Rates : 0;
                rate *= this.Interest;
            }
            calculatedRate = this.Balance*(1 + rate);
            return calculatedRate;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
