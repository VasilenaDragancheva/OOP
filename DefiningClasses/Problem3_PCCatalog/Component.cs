using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price=5;

        public Component(string name,decimal price)
            :this(name,null,price)
        {

        }
        public Component(string name,string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Components name can not be null !");
                }
                this.name = value;
            }
        }
        public string Details { get; set; }
        public decimal Price { 
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price value can not be negative!");
                }
                this.price = value;
            }
        }  
    }
}
