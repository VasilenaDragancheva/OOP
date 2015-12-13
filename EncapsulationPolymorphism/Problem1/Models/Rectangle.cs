using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Models
{
    public class Rectangle : BaseShape
    {
        public Rectangle(double width, double height)
            :base(width,height)
        {

        }

        public override double CalculateArea()
        {
            double area = this.Width * this.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            return (this.Width + this.Height) * 2;
        }
    }
}
