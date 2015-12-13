using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.Contracts;
namespace Problem2
{
    class Payment:IPayment
    {

        public Payment(string productName,decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        public string ProductName { get; set; }

        public decimal Price{get;set;}
    }
}
