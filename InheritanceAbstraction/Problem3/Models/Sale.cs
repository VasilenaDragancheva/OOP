using System;
using Problem3.Interfaces;

namespace Problem3.Models
{
   public class Sale : ISale
    {
        private string productName;
        
        private decimal price;
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;

        }
        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name can not be null!");
                }
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get;
            set;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price is non negative!");

                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} sold on {1} for {2} lv.", this.ProductName, this.Date, this.Price);
        } 
    }
}
