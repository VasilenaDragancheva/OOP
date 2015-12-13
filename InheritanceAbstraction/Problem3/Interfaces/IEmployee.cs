using System;
using Problem3.Enum;

namespace Problem3.Interfaces
{
    interface IEmployee
    {
        decimal Salary { get; set; }
        Department Deparment { get; set; }
    }
}
