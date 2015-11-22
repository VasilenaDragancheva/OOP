using System;
using Problem4_SLS.Interfaces;

namespace Problem4_SLS.Classes
{
    abstract class Trainer:Person,ITrainer
    {
        public Trainer(string firstName,string lastName,int age):base(firstName,lastName,age)
        {

        }
        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} was created",courseName);
        }
    }
}
