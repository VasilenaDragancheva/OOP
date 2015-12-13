using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Engine;
using Empires.Engine.Interfaces;

namespace Empires
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputReader reader=new ConsoleInputReader();
            IOutputWriter writer=new ConsoleOutputWriter();
            IDatabase database=new Database();
            IEngine engine=new EmpireEngine(reader,writer,database);
            engine.Run();
        }
    }
}
