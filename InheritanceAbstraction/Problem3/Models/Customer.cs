using System;

using Problem3.Interfaces;

namespace Problem3.Models
{
    public class Customer:Person,ICustomer
    {
        private decimal netAmountPurchase;
        public Customer(string firstName, string lastName,int id,decimal netAmountPurchase)
            :base(firstName,lastName,id)
        {
            this.NetAmountPurchase = netAmountPurchase;
        }

        public decimal NetAmountPurchase
        {
            get
            {
                return this.netAmountPurchase;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Amount is non negative number!");
                }
                this.netAmountPurchase = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} has spent {2:f2}",base.ToString(),this.NetAmountPurchase);
        }
    }
}
