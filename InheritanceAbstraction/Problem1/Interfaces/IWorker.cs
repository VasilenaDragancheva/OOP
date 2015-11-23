using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Interfaces
{
    //WeekSalary and WorkHoursPerDay and method MoneyPerHour()
    interface IWorker
    {
        decimal WeekSalary { get; set; }
        int WorkHoursPerDay { get; set; }
        decimal MoneyPerHour();
    }
}
