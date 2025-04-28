namespace Lab4
{
    public class Student : Person, IDisplayable, IContainer
    {
        private static int id = 1;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get; }
        public Student(string firstName, string lastName, DateTime birthDate, string specialization, int group, int semester = 1) : base(firstName, lastName, birthDate)
        {
            Specialization = specialization;
            Semester = semester;
            Group = group;
            IndexId = id;
            id++;
            this.Grades = new List<FinalGrade>();
        }
        public override string ToString()
        {
            return base.ToString() + $"Student | {Specialization}, {Group}, {Semester}, {IndexId}\n";
        }
    }
}
