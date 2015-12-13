using System;
using EstateAgency.Attributes;

namespace EstateAgency.Models.Estates
{
     [Estate]
    class House : Estate
    {
        private int floorsCount;

        public House(string name, double area, string location, bool furniture, int floorsCount)
            : base(name, EstateType.House, area, location, furniture)
        {
            this.FloorsCount = floorsCount;
        }
        public int FloorsCount
        {
            get { return this.floorsCount; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();

                }
                this.floorsCount = value;
            }
        }
    }
}
