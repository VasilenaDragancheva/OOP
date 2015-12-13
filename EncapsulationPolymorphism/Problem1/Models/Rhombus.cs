using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Models
{
    public class Rhombus : BaseShape
    {
        private double diagonal1;
        private double diagonal2;
        public Rhombus(double width,double diagonal1,double diagonal2)
            :base(width,width)
        {

            this.Diagonal1 = diagonal1;
            this.Diagonal2 = diagonal2;
        }
        public double Diagonal1 
        { 
            get
            {
                return this.diagonal1;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Value can not be negative");
                }
                this.diagonal1 = value;
            }
        }
        public double Diagonal2
        {
            get
            {
                return this.diagonal2;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value can not be negative");
                }
                this.diagonal2 = value;
            }
        }

        public override double CalculateArea()
        {
            return (this.diagonal1 * this.diagonal2)/2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 4;
        }
    }
}
