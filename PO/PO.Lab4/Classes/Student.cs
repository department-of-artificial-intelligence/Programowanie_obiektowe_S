using Lab4.App;

namespace PO.Lab4.Classes
{
    public class Student : Person, IContainer, IDisplayable
    {
        private static int id;
        public IList<FinalGrade> Grades { get; set; }

        public int Semestr { get; set; }

        public int Group { get; set; }

        public int IndexId { get; set; }

        public string Specialization { get; set; }

        public double AvarageGrades { get; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1) : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semestr = semester;
            Grades = new List<FinalGrade>();
        }

        public override string ToString()
        {
            return base.ToString() + $"Specialization{Specialization}, Grup{Group},Semester{Semestr}";
        }
    }


}
