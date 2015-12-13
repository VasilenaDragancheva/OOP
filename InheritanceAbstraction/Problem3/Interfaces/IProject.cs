using System;
using System.Collections.Generic;
using Problem3.Enum;

namespace Problem3.Interfaces
{
    interface IProject
    {
        string Name { get; set; }
        DateTime StartDate { get; set; }
        List<string> Details { get;}
        ProjectState ProjectState { get; set; }
    }
}
