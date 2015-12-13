using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.Interfaces
{
    interface IManager
    {
        IEnumerable<Employee> EmployeesUnderCommand { get;  }
    }
}
