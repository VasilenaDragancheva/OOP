using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Engine.Interfaces
{
    public interface IEngine
    {
        IInputReader Reader { get; }
        IOutputWriter Writer { get; }
        IDatabase Database { get; }
        void Run();
    }
}
