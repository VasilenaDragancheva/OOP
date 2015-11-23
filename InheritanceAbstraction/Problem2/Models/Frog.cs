using System;
using Problem2.Enum;


namespace Problem2.Models
{
    class Frog:Animal
    {
        public Frog(string name,int age,Gender gender)
        :base(name,age,gender)

        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kvak!");
        }
    }
}
