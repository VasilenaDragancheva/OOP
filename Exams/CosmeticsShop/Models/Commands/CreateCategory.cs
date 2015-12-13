using CosmeticsShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Models.Commands
{
   public class CreateCategory:Command
    {
       
       public CreateCategory(IEngine engine):base(engine)
       {

       }
        public override string ExecuteCommand(string[] tokens)
        {
            string name = tokens[0];
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }
            ICategory category = this.Engine.FindCategory(name);
            if(category!=null)
            {
                return "Category with name " + name + " exists";
            }
            this.Engine.AddCategory(name);
            return "Succesfully added new category with name " + name;
            
        }
    }
}
