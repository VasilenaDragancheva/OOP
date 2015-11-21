using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray bit = new BitArray(100000);
            bit[0] = 1;
            bit[12] = 1;
            bit[100000 - 1] = 1;
            Console.WriteLine(bit);
            
           
        }
    }
}
