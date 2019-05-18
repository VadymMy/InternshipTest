using System;
using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private List<Student> Interns = new List<Student>(); 
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
        public Internship(string name)
        {
            Name = name;      
        }
        public string GetStudents()
        {   
            string answer = "";
            foreach(Student intern in Interns)
            {
                answer += intern.Name + "\n";
            }        
            return answer;
        }
        private void SetInterns()
        {            
            List<Student> allStudents =  University.GetStudentList();            
            double avg = AverageNote(allStudents);
            CheckStudents(allStudents, avg);
        }
        private double AverageNote(List<Student> students)
        {
            double answer = 0;
            for(int i = 0; i < students.Count; i++)            
                answer += Convert.ToDouble(students[i].knowledgeLevel);
            answer /= students.Count;
            return answer - answer % 0.1;
        }
        private void CheckStudents(List<Student> students, double avgNote)
        {
            foreach(Student stud in students)
            {
                Knowledge studKnowledge = stud.knowledgeLevel;
                if(studKnowledge.Level > avgNote)
                    AddIntern(stud);
            }
        }
        private void AddIntern(Student intern)
        {
            Interns.Add(intern);
        }
    }
}
