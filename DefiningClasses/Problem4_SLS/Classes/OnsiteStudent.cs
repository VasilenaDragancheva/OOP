using System;


namespace Problem4_SLS.Classes
{
    public class OnsiteStudent:CurrentStudent
    {

        private int visits;
        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, 
            string currentCourse,int visits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.Visits = visits;
        }
        public int Visits
        {
            get
            {
                return this.visits;
            }

            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Visits is non negative number");
                }
                this.visits = value;
            }
        }
    }
}
