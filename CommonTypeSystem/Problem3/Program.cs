using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDisperser str = new StringDisperser("aaaaaa", "bbbbbbbb");
            foreach (var symb in str)
            {
                Console.WriteLine( symb);
            }
        }
    }
}
