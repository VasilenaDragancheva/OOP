using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Buildings
{
    public class Archery:Building
    {
        private const int ResourceQuantity = 5;
        private const int TurnsUnit = 3;
        private const int TurnsResource = 2;
        private const string NameOfUnit = "Archer";

        public Archery():base(TurnsUnit, TurnsResource, ResourceQuantity, ResourceType.Gold, NameOfUnit)
        {
            
        }

        public override string ToString()
        {
            int turnsToUnit = TurnsUnit - this.TurnsAfterCreation%TurnsUnit;
            int turnsToRecource = TurnsResource - this.TurnsAfterCreation%TurnsResource;
            return String.Format("--Archery: turns {0} ({1} turns until Archer, {2} turns until Gold)",this.TurnsAfterCreation,turnsToUnit,turnsToRecource);
        }
    }
}
