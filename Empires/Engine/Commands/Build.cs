using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Engine.Factories;
using Empires.Engine.Interfaces;

namespace Empires.Engine.Commands
{
   public class Build:Command
    {
       public Build(IEngine engine):base(engine)
       {
           
       }
        public override string Execute(params string[] commandParams)
        {
            string inputName = commandParams[0];

            StringBuilder buildingName=new StringBuilder();
            buildingName.Append(inputName[0].ToString().ToUpper());
            buildingName.Append(inputName.Substring(1));

            var building = BuildingFactory.CreateBuilding(buildingName.ToString());
            this.Engine.Database.AddBuilding(building);
            return "";
        }
    }
}
