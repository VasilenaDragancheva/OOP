using System;
using System.Collections.Generic;
using Problem3.Enum;
using Problem3.Interfaces;
using System.Linq;
using System.Text;

namespace Problem3.Models
{
   public class Manager : Employee,IManager
    {
      private List<Employee> employeesUnderCommand;
        public Manager(string firstName, string lastName, int id, decimal salary, Department department, params Employee[] employees)
            : base(firstName, lastName, id, salary, department)
        {
            List<Employee> input=new List<Employee>();
            input.AddRange(employees);
            this.employeesUnderCommand =input;
        }

        public IEnumerable<Employee> EmployeesUnderCommand
        {
            get
            {
                return this.employeesUnderCommand;
            }
           
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} works on:", base.ToString());
            if (this.EmployeesUnderCommand.Count() == 0)
            {
                //strange but possible
                result.Append("No employees!");
            }
            else
            {
                foreach (Employee empl in this.EmployeesUnderCommand)
                {
                    result.AppendFormat("{0}\n", empl.FirstName);
                }
            }
            return result.ToString();
        }

    }
}
