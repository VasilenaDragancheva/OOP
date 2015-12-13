using System;
using Problem1.Interfaces;

namespace Problem1.Models
{
    public class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if(value<=0)
                {
                    throw new ArgumentOutOfRangeException("Radius is positive!");
                }
                this.radius = value;
            }
        }


        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
            
        }

        public double CalculatePerimeter()
        {
            return Math.PI * 2 * this.Radius;
        }
    }
}
