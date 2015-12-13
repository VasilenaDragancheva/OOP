using System;
using System.Collections.Generic;
using Problem3.Models;

namespace Problem3.Interfaces
{
    interface ISalesEmployee
    {
        IEnumerable<Sale> Sales { get; }
    }
}
