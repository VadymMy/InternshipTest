namespace InternshipTest.Person
{    
    public class Student
    {
        public string Name{get; private set;}
        public Knowledge knowledgeLevel{get; private set;}
        public Student(string name, Knowledge level)
        {
            Name = name;
            SetKnowledge(level);
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            knowledgeLevel = knowledge;
        }
    }
}