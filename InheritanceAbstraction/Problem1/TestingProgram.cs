using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.Models;

namespace Problem1
{
    class TestingProgram
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Angel","Angelov","12343"),
                new Student("Bojidar","Bratoev","432d213"),
                new Student("Cikoriq","Ciklamena","hd732j"),
                new Student("Dobra","Dudeva","9189819"),
                new Student("Elen","Elenov","72j21"),
                new Student("Fred","Flinstone","3fjjf2"),
                new Student("Gergana","Grudeva","8932929"),
                new Student("Haralambii","Hristov","r8w0q"),
                new Student("Iliq","Iliev","erdew"),
                new Student("Jecho","Jechev","73h371")
            };
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Anton","Antonov",100,2),
            new Worker("Borko","Biserov",300,8),
            new Worker("Cveta","Cimilova",200,4),
            new Worker("Duda","DObreva",600,4),
            new Worker("Emiliq","Encheva",120, 2),
            new Worker("Fani","Filipova",130,8),
            new Worker("Grigorii","Georgoev",200,8),
            new Worker("Hristo","Hristov",246,8),
            new Worker("Ivan","Ivanov",250,8),
            new Worker("Jelqzko","Jelev",200,8)
            };
            Console.WriteLine("###Students###");
            
            students.OrderBy(st => st.StudentNumber).ToList().ForEach(st => Console.WriteLine("{0} -stud number-> {1}", st.FistName, st.StudentNumber));
            Console.WriteLine("###Workers###");
            
            workers.OrderByDescending(wr => wr.MoneyPerHour()).ToList().ForEach(wr => Console.WriteLine("{0} -money per hour->{1}", wr.FistName, wr.MoneyPerHour()));

            List<Human> humans = new List<Human>();
            humans.AddRange(workers);
            humans.AddRange(students);
            Console.WriteLine("###Humans###");
            humans
                .OrderBy(h => h.FistName)
                .ThenBy(h => h.LastName)
                .ToList()
                .ForEach(h => Console.WriteLine("{0} {1}", h.FistName, h.LastName));
        }
    }
}
