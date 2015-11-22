using System;
using System.Collections.Generic;
using System.Linq;
using Problem4_SLS.Classes;

namespace Problem4_SLS
{
    class SULSTest
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>()
            {
            new JuniorTrainer("Dragan","Draganov",30),
        new JuniorTrainer("Petko","Petkov",26),
        new SeniorTrainer("Dimityr","Dimitrov",29),
        new DropoutStudent("Pesho","Peshev",22,"2382A",3.4,"Lazy"),
        new OnlineStudent("Pepa","Pramatarova",22,"2212B",5.5,"OOP"),
        new OnsiteStudent("Mila","Dimililova",32,"2323A",4,"Databases",4),
        new OnlineStudent("Mira","Ivanoca",19,"3434",3,".NET"),
        new OnlineStudent("Gosho","Tenkov",33,"5423D",5.4,"JavaScript")
        };

            var students = persons
                 .OfType<CurrentStudent>()
                 .OrderByDescending(st => st.AverageGrade);

            foreach(var student in students)
            {
                Console.WriteLine("{0}-->{1}",student.FirstName,student.AverageGrade);
            }
                
                
        }

    }
}
