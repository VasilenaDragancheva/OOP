using CosmeticsShop.Engines;
using CosmeticsShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CosmeticsShop.Engines;

namespace CosmeticsShop
{
    class CosmeticShopProgram
    {
        static void Main(string[] args)
        {
            IInputReader  reader= new InputReader();
            CommandDispatcher dispacther = new CommandDispatcher();
            IEngine engine = new Engine(dispacther, reader);
           
            engine.Run();
        }
    }
}
