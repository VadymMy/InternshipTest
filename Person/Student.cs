namespace InternshipTest.Person
{    
    public class Student
    {
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