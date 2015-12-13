using CosmeticsShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Engines
{
    public class InputReader:IInputReader
    {
        public InputReader()
        {
        }
        public string ReadLine()
        {
            string line = Console.ReadLine();
            return line;
        }
    }
}
