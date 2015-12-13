using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.Interfaces;

namespace Problem1
{
   public abstract class Human:IHuman
    {
        private string firstName;
        private string lastName;

        protected  Human (string firstName,string lastName)
	{
        this.FistName = firstName;
        this.LastName = lastName;
	}

        public string FistName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                this.lastName = value;
            }
        }
    }
}
