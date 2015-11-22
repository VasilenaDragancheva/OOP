using System;
using Problem4_SLS.Interfaces;

namespace Problem4_SLS.Classes
{
    class SeniorTrainer:Trainer,ISeniorTrainer
    {
        public SeniorTrainer(string firstName,string lastName,int age)
            :base(firstName,lastName,age)
        {
                
        }
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("{0} was deleted",courseName);
        }
    }
}
