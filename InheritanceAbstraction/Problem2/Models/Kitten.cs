using System;
using Problem2.Enum;

namespace Problem2.Models
{
  public  class Kitten:Cat
    {
        private const Gender FEMALE = Gender.Female;
        public Kitten(string name,int age)
            :base(name,age,FEMALE)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Mrrrr Mau");
        }
    }
}
