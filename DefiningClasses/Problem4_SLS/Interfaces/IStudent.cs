using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_SLS.Interfaces
{
    interface IStudent
    {
        string StudentNumber { get; set; }
        double AverageGrade { get; set; }
    }
}
