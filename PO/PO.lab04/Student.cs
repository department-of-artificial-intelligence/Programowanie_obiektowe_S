namespace PO.lab04
{
    public class Student : Person
    {
        private static int _id;
        public IList<FinalGrade> Grades
        {
            get { return Grades; }
            set { Grades = value; }
        }
        public int Semester { get => Semester; set => Semester = value; }
        public int Group { get => Group; set => Group = value; }
        public int IndexId { get => _id; set => _id = value; }
        public string Specialization { get => Specialization; set => Specialization = value; }
        public double AverageGrades { get => AverageGrades; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization
            , int group, int semester = 1) : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
            IndexId = _id++;
        }
        public override string ToString()
        {
            return base.ToString() + $"| Semester: {Semester} | Group: {Group}" +
                $"| Index ID: {IndexId} | Specialization: {Specialization} " +
                $"| Average Grades: {AverageGrades}";
        }
    }
}
