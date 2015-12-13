using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.Interfaces;
namespace Problem1
{
    public abstract class BaseShape : IShape
    {
       private double width;
       private double height;
       protected BaseShape(double width,double height)
       {
           this.Width = width;
           this.Height = height;
       }

       public double Width 
       {
           get
           {
               return this.width;
           }
           set
           {
               if(value<0)
               {
                   throw new ArgumentOutOfRangeException("Width can not be null");
               }
               this.width = value;
           }
       }
       public double Height
       {
           get
           {
               return this.height;
           }
           set
           {
               if (value < 0)
               {
                   throw new ArgumentOutOfRangeException("Height can not be null");
               }
               this.height = value;
           }
       }


        public abstract double CalculateArea();


        public abstract double CalculatePerimeter();
        
    }
}
