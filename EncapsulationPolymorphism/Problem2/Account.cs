using System;
using System.Collections.Generic;
using System.Linq;
using Problem2.Interfaces;
using Problem2.Enums;
namespace Problem2
{
    public abstract class Account : IAccount
    {
        private const decimal MIN_RATE = 0;
        private const decimal MAX_RATE = 1;

        private readonly DateTime startDate;
        private string customerID;
       
        protected decimal balance;
        private decimal interest;
        protected Account(string  customerID,CustomerType customerType,decimal  balance,decimal interest)
        {
            this.CustomerID = customerID;
            this.Balance = balance;
            this.Interest = interest;
            this.startDate = DateTime.Today;
            this.CustomerType=customerType;
        }
        public string CustomerID { 
            
            get
            {
                return this.CustomerID;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("Customer should not be null");
                }
                this.customerID = value;
            }
        }

        
        public abstract decimal Balance { get;  set; }
        

        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            set
            {
                if(value>MAX_RATE||value<MIN_RATE)
                {
                    throw new ArgumentOutOfRangeException("Valid interest is in range of 0 to 1");
                }
                this.interest = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
        }
        public abstract decimal CalculateInterest();
        protected int MonthsFromStartDate()
        {
            DateTime today = DateTime.Today;
            int months = (today.Year - this.StartDate.Year) * 12 + (today.Day> this.startDate.Day ? 0 : -1);
            return months;
        }

        public CustomerType CustomerType { get; set; }
      
    }
}
