using CosmeticsShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Models
{
    public class ShoppingCard : IShoppingCard
    {

        private List<IProduct> products;
        public ShoppingCard()
        {
            this.products = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Null product can not be added to list");
            }
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {


            if (product == null)
            {
                throw new ArgumentNullException();
            }

            this.products.Remove(product);

        }



        public decimal CalculatePrice(ICollection<IProduct> products)
        {
            if (products == null)
            {
                throw new ArgumentNullException();
            }
            decimal price = 0;
            foreach (IProduct product in products)
            {
                price += product.Price;
            }
            return price;
        }
    }
}
