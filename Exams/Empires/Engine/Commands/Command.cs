using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Engine.Interfaces;

namespace Empires.Engine.Commands
{
    public abstract class Command
    {
        private IEngine engine;

        protected Command(IEngine engine)
        {
            this.Engine = engine;
        }

        public IEngine Engine { get; set; }
        public abstract string Execute(params string[] commandParams);

    }
}
