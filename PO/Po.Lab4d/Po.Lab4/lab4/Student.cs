namespace lab4
{
    public class Student : Person, IContainer
    {
        private static int _id { get; set; }

        public IList<FinalGrade>? Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexID { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get; }

        public Student()
            :base()
        {
            Specialization = "nieznana";
            Group = 0;
            Semester = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester=0)
        : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }

        public override string ToString()
        {
            
            string s2 = $"First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth}, Semester: {Semester}, Group: {Group}, Specialization : {Specialization} \n ";
            if (Grades == null)
            {
                return s2;
            }
            else
            {
                string s1 = string.Join(", ", Grades);
                return s2 + s1;
            }
        }

    }
}
