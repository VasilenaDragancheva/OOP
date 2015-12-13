using System;
using System.Collections.Generic;
using Problem3.Models;

namespace Problem3.Interfaces
{
    interface IDeveloper
    {
        IEnumerable<Project> Projects { get;}
        void CloseProject(Project project);
    }
}
