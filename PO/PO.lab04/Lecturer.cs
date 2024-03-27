namespace PO.lab04
{
    public class Lecturer : Person
    {
        public string AcademicTitle { get => AcademicTitle; set => AcademicTitle = value; }
        public string Position { get => Position; set => Position = value; }
        Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string position)
            : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }
        public override string ToString()
        {
            return base.ToString() + $"| Academic Title: {AcademicTitle}| Position: {Position}";
        }
    }
}
