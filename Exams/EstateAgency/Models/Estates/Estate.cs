using System;
using EstateAgency.Attributes;
using EstateAgency.Models.Interfaces;

namespace EstateAgency.Models.Estates
{
     [Estate]
    public abstract class Estate : IEstate
    {
        private string name;
        private double area;
        private string location;
 

        protected Estate(string name, EstateType estateType, double area, string location, bool furniture)
        {
            this.Name = name;
            this.EstateType = estateType;
            this.Area = area;
            this.Location = location;
            this.Furniture = furniture;


        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public EstateType EstateType { get; private set; }

        public double Area
        {
            get { return this.area; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("area", "must be postitve");
                }
                this.area = value;
            }
        }

        public string Location
        {
            get { return this.location; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.location = value;
            }

        }

        public bool Furniture { get; private set; }
    }
}
