using System;
using EstateAgency.Attributes;


namespace EstateAgency.Models.Estates
{
     [Estate]
    class Garage : Estate
    {
        private double width;
        private double height;

        public Garage(string name, double area, string location, bool furniture, double width, double height)
            : base(name, EstateType.Garage, area, location, furniture)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.height = value;
            }
        }
    }
}
