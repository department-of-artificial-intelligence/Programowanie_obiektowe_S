namespace Lab8.WpfApp
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumerIndeksu { get; set; }
        public string Department { get; set; }

        public List<Grade> JoinedGrades { get; set; }

        public Student() { }

        public Student(string firstName, string lastName, int numerIndeksu, string department, List<Grade> grades)
        {
            FirstName = firstName;
            LastName = lastName;
            NumerIndeksu = numerIndeksu;
            Department = department;
            JoinedGrades = grades;
        }
    }
}
