using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.Interfaces
{
    interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        Decimal Price { get; set; }
    }
}
