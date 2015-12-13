using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_SLS.Classes
{
   public abstract class CurrentStudent : Student
    {

        private string currentCourse;

        protected CurrentStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {

        }
        public string CurrentCourse 
        {
            get
            {
                return this.currentCourse;
            }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                { 
                    throw new ArgumentNullException(); 
                }
                this.currentCourse = value;
            } 
        }
    }
}
