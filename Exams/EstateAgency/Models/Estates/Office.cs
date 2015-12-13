using System;
using  EstateAgency.Attributes;
using EstateAgency.Models.Interfaces;

namespace EstateAgency.Models.Estates
{
     [Estate]
    class Office : Estate, IElevatorHavable, IRoomsCountable
    {
        private int roomsCount;
        public Office(string name, double area, string location, bool furniture, int roomsCount, bool haveElevator)
            : base(name, EstateType.Garage, area, location, furniture)
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

