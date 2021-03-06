﻿using CosmeticsShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Models.Commands
{
    public class AddToCategory:Command

    {
        public AddToCategory(IEngine engine):base(engine)
        {

        }

        public override string ExecuteCommand(string[] tokens)
        {
            string categoryName = tokens[0];
            string productName = tokens[1];
            ICategory category = this.Engine.FindCategory(categoryName);
            IProduct product = this.Engine.FindProduct(productName);
            if(category==null)
            {
                throw new ArgumentNullException("Not exciting category");
            }
            if (product == null)
            {
                throw new ArgumentNullException("Not exciting product");
            }
            category.AddProduct(product);
            return "Successfully added product " + product.Name + "to category " + category.Name;
                
        }
    }
}
