using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.Enums;
namespace Problem2.Contracts
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string ID { get; set; }
        string Mail { get; set; }
        string PermanentAddress { get; set; }
        string MobilePhone { get; set; }
        IEnumerable<IPayment> Payments {get;}
        CustomerType CustomerType { get; set; }
        void AddPayment(IPayment Payment);
    }
}
