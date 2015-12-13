using System;
using System.Linq;
using System.Reflection;
using Empires.Attributes;
using Empires.Models.Interfaces;

namespace Empires.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private int turnsAfterCreation;
        private int quantityResourse;
        private ResourceType resourceType;

        protected Building(int turnsToProduceUnit, int turnsToProduceResource, int quantityResource, ResourceType resourceType, string unitName)
        {
            this.TurnsToProduceResource = turnsToProduceResource;
            this.TurnsToProduceUnit = turnsToProduceUnit;
            this.TurnsAfterCreation = -1;
            this.QuantityResource = quantityResource;
            this.ResourceType = resourceType;
            this.UnitName = unitName;
        }

        public int TurnsToProduceUnit { get; private set; }
        public int TurnsToProduceResource { get; private set; }
        public int QuantityResource { get; private set; }
        public ResourceType ResourceType { get; private set; }
        public string UnitName { get; private set; }
        public int TurnsAfterCreation
        {
            get { return this.turnsAfterCreation; }
            //TODO validation 
            set { this.turnsAfterCreation = value; }
        }

        public virtual IUnit ProduceUnit()
        {
            if (this.turnsAfterCreation < this.TurnsToProduceUnit ||
                this.turnsAfterCreation % this.TurnsToProduceUnit != 0)
            {
                return null;
            }

            var unitType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(
                    type =>
                        type.CustomAttributes.Any(a => a.AttributeType == typeof(UnitAttribute)) &&
                        type.Name == this.UnitName);

            if (unitType == null)
            {
                throw new ArgumentNullException();
            }
            var unit = Activator.CreateInstance(unitType) as IUnit;
            return unit;

        }

        public IResource ProduceResource()
        {
            if (this.turnsAfterCreation < this.TurnsToProduceResource ||
               this.turnsAfterCreation % this.TurnsToProduceResource != 0)
            {
                return null;
            }

            return new Resource(this.QuantityResource, this.ResourceType);
        }

    }
}
