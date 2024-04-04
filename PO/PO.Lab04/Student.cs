namespace PO.Lab04
{
    internal class Student : Person, IContainer, IDisplayable
    {
        //private static int _id;


        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1)
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }

        public override string ToString()
        {
            string gradeStr = "";
            if (Grades != null)
            {
                gradeStr = ", Grades:";
                foreach (var grade in Grades)
                {
                    gradeStr += "\n      " + grade.ToString();
                }
            }


            return $"Student | {base.ToString()}, Specialization: {Specialization}, Semester: {Semester}, Group: {Group} {gradeStr}";
        }
    }
}
