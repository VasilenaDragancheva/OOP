using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Models.Products
{
    public class Shampoo:Product
    {
        private double quantity;
        public Shampoo(string name,string brand,decimal price,Gender gender,double quantity,Usage usage):base(name,brand,price,gender)
        {
            this.Quantity = quantity;
            this.Usage = usage;
        }
        public double Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("quantity");
                }
                this.quantity = value;
            }
        }
        public Usage Usage { get; set; }
    }
}
