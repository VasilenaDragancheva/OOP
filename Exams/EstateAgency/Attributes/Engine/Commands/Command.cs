using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency.Engine.Commands
{
    public abstract class Command
    {
        private DataBase dataBase;

        protected Command(DataBase dataBase)
        {
            this.DataBase = dataBase;
        }

        public DataBase DataBase
        {
            get { return this.dataBase; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.dataBase = value;
            }
        }

        public abstract string Execute(params string[] commandParams);
    }
}
