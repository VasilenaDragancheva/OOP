using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.Enums;

namespace Problem2.Interfaces
{
    public interface ICustomer:ICustomerID,ICustomerType
    {
        string CustomerName { get; set; }
    }
}
