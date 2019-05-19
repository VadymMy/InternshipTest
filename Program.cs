using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex", new Knowledge(5));
            University university = new University("CH.U.I.");
            university.AddStudent(new Student(("Andrew Kostenko"), new Knowledge(3)));
            university.AddStudent(new Student(("Julia Veselkina"), new Knowledge(4)));
            university.AddStudent(new Student(("Maria Perechrest"), new Knowledge(5)));

            University university2 = new University("CH.D.T.U");
            university2.AddStudent(new Student(("Prokopenko Serj"), new Knowledge(5)));
            university2.AddStudent(new Student(("Julia Vereschagina"), new Knowledge(4)));
            university2.AddStudent(new Student(("Peter Parker"), new Knowledge(5)));
            
            Internship internship = new Internship("Interlink");
            internship.AddUniversity(university);
            internship.AddUniversity(university2);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
