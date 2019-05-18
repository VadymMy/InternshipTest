using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        private static List<Student> Students = new List<Student>();
        public static List<Student> GetStudentList()
        {
            return Students;
        }
        public string Name{get; private set;}
        public University(string name)
        {
            Name = name;
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }        
    }
}
