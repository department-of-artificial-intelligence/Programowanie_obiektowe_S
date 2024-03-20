namespace lab04
{
    public class Student : Person, IContainer
    {
        private int id = 1;
        private static int count = 0;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades
        {
            get
            {
                return 0;
            }
        }
        public Student(string firstName, string lastName, DateTime birth,
                       string spec, int group, int sem = 1)
            : base(firstName, lastName, birth)
        {
            Specialization = spec;
            Group = group;
            Semester = sem;

            id = ++count;
        }
    }
}
