using System;
using System.Collections.Generic;
using System.Linq;
using Problem2.Models;
using Problem2.Enum;

namespace Problem2
{
    class AnimalProgram
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Kitten("Mari",4),
                new Frog("Kyrmit",2,Gender.Female),
                new Dog("Sharo",9,Gender.Male),
                new Dog("Bella",1,Gender.Female),
                new Frog("Jaba kekerica",1,Gender.Female),
                new Frog("Krastava",3,Gender.Male),
                new Dog("Rino",1,Gender.Male),
                new Dog("Keta",13,Gender.Female),
                new Kitten("Maca",9),
                new Kitten("Cyrna maca",10),
                new Tomcat("Bql kotak",2),
                new Tomcat("Tomi",12),
            };

         
            foreach (var animalType in animals.GroupBy(a => a.GetType()))
            {

                double averageAge = animalType.Select(a => a.Age).Average();
                Console.WriteLine("Average age of {0} is {1:f2}", animalType.Key.Name, averageAge);
            }
        }
    }
}
