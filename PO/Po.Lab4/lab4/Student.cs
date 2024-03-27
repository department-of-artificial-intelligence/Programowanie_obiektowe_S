namespace lab4
{
    public class Student : Person
    {
        private static int _id { get; set; }

        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexID { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester)
        : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }

        public override string ToString()
        {

            string s1 = string.Join(", ", Grades);
            string s2 = $"First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth}, Semester: {Semester}, Group: {Group}, Specialization : {Specialization} ";
            return s1 + s2;
        }

    }
}
