using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        private List<Student> Students = new List<Student>();
        public List<Student> GetStudentList()
        {
            return Students;
        }
        public string Name
        {
            get
            {
                return Name;
            }
            private set
            {
                if(value != null && value.Length > 0)
                    Name = value; 
            }
        }
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
