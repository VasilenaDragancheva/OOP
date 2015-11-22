using System;
using Problem4_SLS.Interfaces;


namespace Problem4_SLS.Classes
{
    abstract class Student : Person, IStudent
    {
        private string studentNumber;
        private double averageGrade;

        protected Student(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public string StudentNumber
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Average grade is in range of 2 to 6");
                }
                this.averageGrade = value;
            }
        }
    }
}
