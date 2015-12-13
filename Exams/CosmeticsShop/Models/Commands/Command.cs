using CosmeticsShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Models.Commands
{
    public abstract class Command
    {
        private IEngine engine;
        protected Command(IEngine engine)
        {
            this.Engine = engine;
        }

        public abstract string ExecuteCommand(string[] tokens);

        public IEngine Engine
        {
            get { return this.engine; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.engine = value;
            }
        }
    }
}

