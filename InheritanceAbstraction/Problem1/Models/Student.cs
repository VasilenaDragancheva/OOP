using System;
using Problem1.Interfaces;
using System.Text.RegularExpressions;

namespace Problem1.Models
{
   public class Student:Human,IStudent
    {
        private string studentNumber;

        public Student(string firstName,string lastName,string studentNumber)
            :base(firstName,lastName)
        {
            this.StudentNumber = studentNumber;
        }
        public string StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                string pattern = "^[a-zA-Z0-9]{5,10}$";
                Regex validNumber = new Regex(pattern);
                bool match = validNumber.IsMatch(value);
                if (!match)
                {
                    throw new ArgumentException("Student number contains 5 to 10 digits and/or letters ");
                }
                this.studentNumber = value;

            }
        }
    }
}
