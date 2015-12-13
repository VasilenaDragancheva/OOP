using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency.Models.Interfaces
{
    public interface IOffer
    {
        IEstate Estate { get; }
        decimal Price { get; }
    }
}
