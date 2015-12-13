using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmeticsShop.Models;

namespace CosmeticsShop.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        string Brand { get; set; }
        decimal Price { get; set; }
        Gender Gender { get; set; }
    }
}
