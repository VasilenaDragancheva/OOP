using System;
using Problem3.Interfaces;

namespace Problem3
{
  public abstract class Person:IPerson
    {
       private string firstName;
       private string lastName;
       private int id;
       protected Person(string firstName,string lastName,int id)
       {
           this.FirstName = firstName;
           this.LastName = lastName;
           this.Id = id;

       }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null!");
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
                    throw new ArgumentNullException("Name can not be null!");
                }
                this.lastName = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Personal ID can not be negative");
                }
                this.id = value;
            }
        }
        public override string ToString()
        {
            return String.Format("{0} {1} has id:{2}", this.FirstName, this.LastName, this.Id);
        }
    }
}
