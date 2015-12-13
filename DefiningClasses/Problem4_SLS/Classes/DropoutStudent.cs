using System;
using System.Text;
using Problem4_SLS.Interfaces;

namespace Problem4_SLS.Classes
{
    public class DropoutStudent:Student,IDroupoutStudent
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade,string dropoutReason)
            :base(firstName,lastName,age,studentNumber,averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }
        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1} aged:{2} dropout for reason: {3}", this.FirstName, this.LastName, this.Age, this.DropoutReason);
            Console.WriteLine(result.ToString());
        }
    }
}
