using System;
using EstateAgency.Models.Interfaces;
using EstateAgency.Attributes;

namespace EstateAgency.Models.Estates
{
    [Estate]
    public class Appartment : Estate, IElevatorHavable, IRoomsCountable
    {
        private int roomsCount;
        public Appartment(string name, double area, string location, bool furniture, int roomsCount, bool haveElevator)
            : base(name, EstateType.Apartment, area, location, furniture)
        {
            this.RoomsCount = roomsCount;
            this.HaveElevator = haveElevator;

        }
        public int RoomsCount
        {
            get { return this.roomsCount; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();

                }
                this.roomsCount = value;
            }
        }

        public bool HaveElevator { get; private set; }
    }
}
