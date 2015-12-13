using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Engine.Interfaces;

namespace Empires.Engine
{
    class ConsoleInputReader : IInputReader
    {
        public string ReadInput()
        {
           return Console.ReadLine();
        }
    }
}
