using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public static class Calculator
    {
       

        public static double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number should be positive");
            }
            return Math.Sqrt(number);
        }

    }

}
