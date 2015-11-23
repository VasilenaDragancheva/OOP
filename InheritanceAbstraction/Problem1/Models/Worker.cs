using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.Interfaces;

namespace Problem1.Models
{
    class Worker:Human,IWorker
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        //WeekSalary and WorkHoursPerDay and method MoneyPerHour()
        public Worker(string firstName,string lastName,decimal weekSalary,int workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary should be non negative");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0||value>8)
                {
                    throw new ArgumentOutOfRangeException("Work hours  should be non negative and less than 8 hours");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return moneyPerHour;
        }
    }
}
