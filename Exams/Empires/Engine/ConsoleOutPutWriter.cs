using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Engine.Interfaces;

namespace Empires.Engine
{
    class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteOutput(string output)
        {
            if (!string.IsNullOrEmpty(output))
            {
                Console.WriteLine(output);
            }
        }
    }
}
