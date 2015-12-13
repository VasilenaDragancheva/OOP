using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem3.Models;

namespace Problem3
{
    class CompanyHierarchyTest
    {

        static void Main(string[] args)
        {
            SalesEmployee man = new SalesEmployee("iv", "iv", 123, 100, Enum.Department.Accounting, new Sale("brava", new DateTime(2012,3,4), 123));
        

            Console.WriteLine(man);
        }

    }
}
