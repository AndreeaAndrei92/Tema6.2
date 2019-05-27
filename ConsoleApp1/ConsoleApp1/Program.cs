using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student primulStudent = new Student("Ana", "Maria", "Cozma", 123456, "Palat", "123456789", "anamaria@ana.com", "Baze de date", Universities.AlexandruIoanCuza, Faculties.Economie, Specialties.Informatica);
            Student doiNrStudent = new Student("Ion", "Marian", "Buza", 654321, "Zimbru", "987654321", "ionutmarian@ion.com", "Tehnologii Web", Universities.AlexandruIoanCuza, Faculties.Economie, Specialties.Informatica);

            Console.WriteLine(Student.Equals(primulStudent, doiNrStudent));
            Console.WriteLine(primulStudent == doiNrStudent);
            Console.WriteLine(primulStudent != doiNrStudent);
            Console.WriteLine();

            Person firstPerson = new Person("Andreea", 23);
            Person secondPerson = new Person("Alex", null);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
