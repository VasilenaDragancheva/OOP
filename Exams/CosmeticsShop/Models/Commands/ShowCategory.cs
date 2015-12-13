using CosmeticsShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Models.Commands
{
    public class ShowCategory:Command
    {
        public ShowCategory(IEngine engine):base(engine)

        {

        }
        public override string ExecuteCommand(string[] tokens)
        {
            string categoryName = tokens[0];
            ICategory category = this.Engine.FindCategory(categoryName);
            if (category == null)
            {
                throw new ArgumentNullException();
            }
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Category {0}{1}has:", category.Name, Environment.NewLine);
            if (category.Products.Count() == 0)
            {
                result.Append("No products");
            }
            else
            {
                foreach (var item in category.Products)
                {
                    result.AppendFormat("{0} {1} {2}",item.GetType().Name,item.Name,Environment.NewLine);
                }
            }
            return result.ToString();

        }
    }
}
