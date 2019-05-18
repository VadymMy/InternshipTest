namespace InternshipTest
{
    public class Knowledge
    {
        public int Level
        {
            get
            {
                return Level;
            }
            private set
            {
                if(value >= 0 && value <= 5)
                    Level = value;
            }
        }
        public Knowledge(int level)
        {
            Level = level;
        }
    }
}
