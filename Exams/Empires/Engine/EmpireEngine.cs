using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Empires.Engine.Commands;
using Empires.Engine.Interfaces;
using Empires.Engine;

namespace Empires
{
    public class EmpireEngine : IEngine
    {
        private IInputReader reader;
        private IOutputWriter writer;
        private IDatabase database;

        public EmpireEngine(IInputReader reader, IOutputWriter writer, IDatabase database)
        {
            this.Reader = reader;
            this.Writer = writer;
            this.Database = database;
        }
        public IInputReader Reader
        {
            get;
            private set;
        }

        public IOutputWriter Writer
        {
            get;
            private set;
        }

        public IDatabase Database { get; private set; }

        public void Run()
        {
            string input;
            while (true)
            {
                 
                 input = this.Reader.ReadInput();
                if (input == "armistice")
                {
                    break;
                }
                try
                {

                    string[] tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string commandName = tokens[0];
                    string[] commandParams = tokens.Skip(1).ToArray();
                    Command command = null;
                    switch (commandName)
                    {
                        case "build":
                            command = new Build(this);
                            break;
                        case "skip":
                            command = new Skip(this);
                            break;
                        case "empire-status":
                            command = new EmpireStatus(this);
                            break;
                        default:
                            throw new ArgumentNullException();

                    }
                    string result = command.Execute(commandParams);
                    this.Writer.WriteOutput(result);
                     this.Upgrade();
                }
                catch (Exception exc)
                {
                    this.Writer.WriteOutput(exc.Message);
                }

            }

        }

        private void Upgrade()
        {

            foreach (var building in this.Database.Buildings)
            {
                building.TurnsAfterCreation++;
                var resource = building.ProduceResource();
                if (resource != null)
                {
                    this.Database.Resources.Add(resource);
                }
                var unit = building.ProduceUnit();
                if (unit != null)
                {
                    this.Database.Units.Add(unit);
                }
                
            }

        }
    }
}
