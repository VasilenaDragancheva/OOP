using System;
using System.Collections.Generic;
using System.Linq;
using CosmeticsShop.Interfaces;
namespace CosmeticsShop.Models
{
    public class Category : ICategory
    {
        private const int maxNameLenght = 15;
        private const int minNameLenght = 2;
        private string name;
        private List<IProduct> products;
        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }


        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("category name");
                }
                if (value.Trim().Length < minNameLenght || value.Trim().Length > maxNameLenght)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Category name must be between {0} and {1} symbols long!", minNameLenght, maxNameLenght));
                }
                this.name = value;
            }
        }
        public IEnumerable<IProduct> Products { get { return this.products; } }

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
            IProduct productToRemove = this.products.FirstOrDefault(pr => pr == product);
            if (productToRemove == null)
            {
                throw new ArgumentNullException(string.Format("Product {0} does not exist in category {1}!", product.Name, this.Name));
            }
            this.products.Remove(productToRemove);
        }
    }
}
