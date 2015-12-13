using Empires.Engine.Interfaces;

namespace Empires.Engine.Commands
{
    public class Skip:Command
    {
        public Skip(IEngine engine):base(engine)
        {
        }

        public override string Execute(params string[] commandParams)
        {
            return "";
        }
    }
}
