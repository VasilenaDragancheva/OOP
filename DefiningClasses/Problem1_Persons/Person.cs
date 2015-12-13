using System;
using System.Linq;
using System.Text;


namespace Problem1_Persons
{
   public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age)
            : this(name, age, null)
        {

        }
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Person`s name can not be null");
                }
                this.name = value;
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
                if (value > 100 || value < 1)
                {
                    throw new ArgumentException("Valid person age is betweem 1 and 100 years");
                }
                this.age = value;

            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Contains('@'))
                {
                    throw new ArgumentException("If person has email it must contain '@'");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            string toString=string.Format("My name is {0}. I`m {1} years old.My email is {2}",this.Name,this.Age,this.Email==null? "not given":this.email);
            return toString;
        }
    }
}
