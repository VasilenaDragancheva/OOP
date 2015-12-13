using CosmeticsShop.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CosmeticsShop.Interfaces;

namespace CosmeticsShop.Engines
{
   public class CommandDispatcher
    {
       public CommandDispatcher()
        {
            
        }

        public virtual Command GetCommandByInput(string commandName, IEngine engine)
        {
            Command command = null;
             
            switch (commandName.ToLower())
            {
                case "createcategory":
                   command = new CreateCategory(engine);
                    break;
                case "addtocategory":
                    command = new AddToCategory(engine);
                    break;
                case "removefromcategory":
                    command = new RemoveFromCategory(engine);
                    break;
                case "showcategory":
                    command = new ShowCategory(engine);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Ivalid command supplied");

            }
            return command;
        }
    }
}
