using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency.Engine.Commands
{
    public class Create:Command
    {
        public Create(DataBase dataBase):base(dataBase)
        {
            
        }

        public override string Execute(params string[] commandParams)
        {

            string type = commandParams[0];
            if (!type.Contains("Offer"))
            {
                
            }
            string name = commandParams[1];
            double area = double.Parse(commandParams[2]);
            string location = commandParams[3];

        }
    }
}
