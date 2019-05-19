using System.Linq;
using System;
using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private List<Student> Interns = new List<Student>();
        private List<Student> AllStudents = new List<Student>(); 
        public string Name{get; private set;}
        public Internship(string name)
        {
            Name = name;  
        }
        public string GetStudents()
        {               
            SetInterns(); 
            string answer = "";
            foreach(Student intern in Interns)
            {
                answer += intern.Name + "\n";
            }        
            return answer;
        }
        public void AddUniversity(University university)
        {
            List<Student> curUniversityStudents = university.GetStudentList();
            foreach(Student student in curUniversityStudents)
                AllStudents.Add(student);
        }
        private void SetInterns()
        {         
            double avg = AverageNote(AllStudents);
            CheckStudents(AllStudents, avg);
        }
        private double AverageNote(List<Student> students)
        {
            double answer = 0;
            for(int i = 0; i < students.Count; i++)
            {            
                Knowledge curStudentKnowledge = students[i].knowledgeLevel;
                answer += Convert.ToDouble(curStudentKnowledge.Level);
            }
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
