using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.Enums;
using Problem2.Interfaces;

namespace Problem2
{
    public class Customer:ICustomer
    {
        private string customerName;
        private string customerID;
        private static int customerIndexator;
        public Customer(CustomerType customerType,string customerName)
        {
            this.CustomerType = customerType;
            this.CustomerName = customerName;
            
            customerIndexator++;
        }
   
        public CustomerType  CustomerType { get; set; }

        public string CustomerName
        {
            get
            {
                return this.customerName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customers name can not be null or empty");
                }
                this.customerName = value;
            }
        }

        public string CustomerID
        {
            get
            {
                return this.customerID;
            }
           private set
            {
                this.customerID = this.customerName + customerIndexator.ToString();
            }
        }
    }

}
