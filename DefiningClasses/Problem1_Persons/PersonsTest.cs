using System;
using System.Collections.Generic;


namespace Problem1_Persons
{
     public class PersonsTest
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
             new Person("Vasilka", 29),
             new Person("Kalinkata", 40),
            new Person("Milenkata", 30, "milenkata@abv.bg"),
            new Person("Vancheto",72,"baba_vanche@gmail.com"),
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            Person david = new Person("David", 43, "david");//throws new argument exceptions
        }
    }
}
