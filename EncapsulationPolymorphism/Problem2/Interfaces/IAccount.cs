using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.Interfaces
{
    public interface IAccount:ICustomerID,ICustomerType
    {
        decimal Balance { get; set; }
        decimal Interest { get; set; }
        DateTime StartDate { get; }
        decimal CalculateInterest();
    }
}
