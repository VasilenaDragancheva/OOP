using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Contracts
{
   public interface IPayment
    {
        string ProductName { get; set; }
        decimal Price { get; set; }
    }
}
