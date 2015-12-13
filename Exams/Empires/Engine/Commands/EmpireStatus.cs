using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Empires.Engine.Interfaces;
using Empires.Models;
using Empires.Models.Units;

namespace Empires.Engine.Commands
{
    public class EmpireStatus : Command
    {
        public EmpireStatus(IEngine engine)
            : base(engine)
        {
        }
        public override string Execute(params string[] commandParams)
        {
            int gold = this.Engine.Database.Resources
                .Where(res => res.Type == ResourceType.Gold)
                .Sum(res => res.Quantity);

            int steel = this.Engine.Database.Resources
           .Where(res => res.Type == ResourceType.Steel)
           .Sum(res => res.Quantity);

            StringBuilder result = new StringBuilder();
            result.AppendFormat("Treasury:{0}", Environment.NewLine);
            result.AppendFormat("--Gold: {0}{1}", gold,Environment.NewLine);
            result.AppendFormat("--Steel: {0}{1}", steel,Environment.NewLine);
            result.AppendFormat("Buildings{0}", Environment.NewLine);
            if (this.Engine.Database.Buildings.Count == 0)
            {
                result.AppendFormat("N/A{0}", Environment.NewLine);
            }
            else
            {
                foreach (var building in this.Engine.Database.Buildings)
                {
                    result.AppendFormat("{0}{1}", building.ToString(), Environment.NewLine);
                }
            }
            result.AppendFormat("Units{0}", Environment.NewLine);
            if (this.Engine.Database.Units.Count == 0)
            {
                result.AppendFormat("N/A{0}", Environment.NewLine);
            }
            else
            {

                int countSwords = this.Engine.Database.Units.Count(unit => unit is Swordsman);
                int countArcher = this.Engine.Database.Units.Count(unit => unit is Archer);
                result.AppendFormat("--Swordsman: {0}{1}", countSwords, Environment.NewLine);
                result.AppendFormat("--Archer: {0}{1}", countArcher, Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
