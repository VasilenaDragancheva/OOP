using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Interfaces
{
    public interface IShoppingCard
    {
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        decimal CalculatePrice(ICollection<IProduct> products);
    }
}
