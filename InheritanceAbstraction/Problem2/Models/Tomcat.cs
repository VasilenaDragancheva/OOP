using System;
using Problem2.Enum;

namespace Problem2.Models
{
    class Tomcat:Cat
    {
        private const Gender MALE = Gender.Male;
        public Tomcat(string name,int age)
            :base(name,age,MALE)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Mau Mau I`m big male cat!");
        }
    }
}
