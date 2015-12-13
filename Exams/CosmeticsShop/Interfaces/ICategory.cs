using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Interfaces
{
    public interface ICategory
    {
        string Name { get; }
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        IEnumerable<IProduct> Products { get; }
    }
}
