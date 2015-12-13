using System;
using Problem3.Interfaces;
using Problem3.Enum;

namespace Problem3
{
  public  abstract class Employee:Person,IEmployee
    {
        private decimal salary;
       
        public Employee(string firstName,string lastName,int id, decimal salary, Department department)
            :base(firstName,lastName,id)
        {
            this.Salary = salary;
            this.Deparment = department;

        }

        public decimal Salary
        {
            get
            {
                return this.salary;  
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Salary can not be negative!");
                }
                this.salary = value;
            }
        }

        public Department Deparment { get; set; }
        public override string ToString()
        {
            return string.Format("{0} works for {1}",base.ToString(),this.Deparment);
        }
    }
}
