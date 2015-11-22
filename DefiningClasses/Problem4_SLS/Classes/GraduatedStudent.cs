using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_SLS.Classes
{
    class GraduatedStudent:Student
    {
        public GraduatedStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            :base(firstName,lastName,age,studentNumber,averageGrade)
        {

        }
    }
}
