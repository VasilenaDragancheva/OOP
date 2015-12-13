using System;
using Empires.Models.Interfaces;
using Empires.Models.Units;

namespace Empires.Models.Buildings
{
    public class Barracks:Building

    {
        //int turnsToProduceUnit, int turnsToProduceResource, int quantityResource, ResourceType resourceType, string unitName

        
        private const int ResourceQuantity = 10;
        private const int TurnsUnit=4;
        private const int TurnsResource = 3;
        private const string NameOfUnit = "Swordsman";

        public Barracks()
            : base(TurnsUnit, TurnsResource, ResourceQuantity, ResourceType.Steel, NameOfUnit)
        {
            
        }

        public override string ToString()
        {
            int turnsToUnit = TurnsUnit - this.TurnsAfterCreation % TurnsUnit;
            int turnsToRecource = TurnsResource - this.TurnsAfterCreation % TurnsResource;
            return String.Format("--Barracks: turns {0} ({1} turns until Swordsman, {2} turns until Steel)", this.TurnsAfterCreation, turnsToUnit, turnsToRecource);

        }
    }
}
