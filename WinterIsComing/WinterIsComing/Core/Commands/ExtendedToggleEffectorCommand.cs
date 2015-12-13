using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
namespace WinterIsComing.Core.Commands
{
    class ExtendedToggleEffectorCommand:ToggleEffectorCommand
    {
        public ExtendedToggleEffectorCommand(IEngine engine):base(engine)
        {
                    
        }
        public override void Execute(string[] commandArgs)
        {
            base.Execute(commandArgs);
        }
    }
}
