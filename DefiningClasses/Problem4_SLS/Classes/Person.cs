using System;
using Problem4_SLS.Interfaces;


namespace Problem4_SLS.Classes
{
   abstract class Person :IPerson
    {
       private string firstName;
       private string lastName;
       private int age;

       protected Person(string firstName,string lastName, int age)
       {
           this.FirstName = firstName;
           this.LastName = lastName;
           this.Age = age;
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
                    throw new ArgumentNullException("Name can not be null");
                }
                this.firstName=value;
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
                
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null");
                }
                this.lastName=value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
               if(value<0)
               {
                   throw new ArgumentOutOfRangeException("Age is positive number");
               }
               this.age = value;
            }
        }
    }
}
