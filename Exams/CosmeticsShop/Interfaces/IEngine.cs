using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Interfaces
{
   public interface IEngine
    {
        IEnumerable<ICategory> Categories { get; }
        void AddCategory(string name);
        ICategory FindCategory(string name);
        IProduct FindProduct(string name);
        void Run();
    }
}
