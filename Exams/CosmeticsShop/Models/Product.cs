using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmeticsShop.Interfaces;

namespace CosmeticsShop.Models
{
   public abstract class Product:IProduct
    {
       private string name;
       private string brand;
       private decimal price;
 
       protected Product(string name,string brand,decimal price,Gender gender)
       {
           this.Name = name;
           this.Brand = brand;
           this.Price = price;
           this.Gender = gender;
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
                    throw new ArgumentNullException("name");
                }
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("brand");
                }
                this.brand = value;
            }
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
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }

        public Gender Gender { get; set; }
    }
}
