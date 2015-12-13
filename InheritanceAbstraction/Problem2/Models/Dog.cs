using System;
using Problem2.Enum;

namespace Problem2.Models
{
   public class Dog:Animal
    {
       public Dog(string name,int age,Gender gender)
            :base(name,age,gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Bau Bau");
        }
    }
}
