namespace Lab8.WpfApp
{
    public class Student
    {
        public string? FirstName { get; set; }
        public string? SurName { get; set; }
        public string? Faculty { get; set; }
        public int StudentNo { get; set; }

        public string? JoinedGrades { get; set; }

        public List<Grade>? Grades { get; set; }

        public string AllGrades => Grades.Count > 0 ? string.Join(", ", Grades) : "";
        public Student(string firstName, string surName, string faculty, int studentNo, List<Grade> grades)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;

            Grades = grades;
        }

        public Student()
        {
        }
    }
}
