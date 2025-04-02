namespace Lab4
{
    public class Student : Person
    {
        private int id;
        public IList<FinalGrade> Grades { get; set; } = new List<FinalGrade>();
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get => id; set => id = value; }
        public string Specialization { get; set; }

        public double AverageGrades()
        {
            if (Grades.Count == 0) return 0;
            return Grades.Average(grade => grade.Value);
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1)
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Semester = semester;
            Group = group;
        }

        public override string ToString()
        {
            var gradesString = Grades.Any() ? string.Join(", ", Grades.Select(g => g.ToString())) : "No grades available";
            return base.ToString() + $" Student ID: {IndexId}, Specialization: {Specialization}, Semester: {Semester}, Group: {Group}, Grades: {gradesString}";
        }
    }
}
