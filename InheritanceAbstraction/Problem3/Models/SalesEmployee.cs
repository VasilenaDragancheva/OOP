using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Problem3.Interfaces;
using Problem3.Enum;
using System.Text;

namespace Problem3.Models
{
   
   public class SalesEmployee:Employee,ISalesEmployee
    {
        private  List<Sale> sales;
        public SalesEmployee(string firstName, string lastName,int id, decimal salary,Department department,params Sale[] sales)
        :base(firstName,lastName,id,salary,department)
        {
            this.sales = new List<Sale>();
            this.sales.AddRange(sales);

        }


        public IEnumerable<Sale> Sales
        {
            get
            {
                return this.sales;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
          
            if (this.Sales.Count() == 0)
            {
                result.Append("made no sales!");
            }
            else
            {
                  result.AppendFormat("{0} made sales:", base.ToString());
                foreach (Sale sale in this.Sales)
                {
                    result.AppendFormat("{0}\n", sale.ToString());
                }
            }
            return result.ToString();
        }
    }
}
