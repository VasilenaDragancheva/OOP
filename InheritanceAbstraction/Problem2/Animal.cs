using System;
using Problem2.Interfaces;
using Problem2.Enum;
namespace Problem2
{
    abstract class Animal:IAnimal,ISoundProducible
    {
        string name;
        int age;
        Gender gender;
        protected Animal(string name,int age,Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
               if(string.IsNullOrEmpty(value))
               {
                   Console.WriteLine("Name can not be null!");
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
               if(value<0)
               {
                   throw new ArgumentOutOfRangeException("Age can not be negative");
               }
               this.age = value;
            }
        }

        public Gender Gender { get; set; }

       public abstract void ProduceSound();
        
    }
}
