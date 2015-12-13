using System;
using Problem2.Interfaces;
using Problem2.Enums;

namespace Problem2.Models
{
    public class MortrageAccount : Account, IDepositable
    {

        private const int Companies_Special_Rates = 12;
        private const int Individuals_Special_Rates = 6;

        public MortrageAccount(string customerID, CustomerType customerType, decimal balance, decimal interest)
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
            if (this.CustomerType == CustomerType.Company)
            {
                if (this.MonthsFromStartDate() > Companies_Special_Rates)
                {
                    rate = Companies_Special_Rates * this.Interest / 2;
                    rate += (this.MonthsFromStartDate() - Companies_Special_Rates) * this.Interest;
                }
                else
                {
                    rate = this.MonthsFromStartDate() * this.Interest;
                }
            }
            else
            {
                rate = this.MonthsFromStartDate() > Individuals_Special_Rates ? this.MonthsFromStartDate() - Individuals_Special_Rates : 0;
                rate *= this.Interest;
            }
            calculatedRate = this.Balance * (1 + rate);
            return calculatedRate;
        }

        public void DepositMoney(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
