namespace PO.Lab4.Classes
{
    public class Lecturer : Person
    {
        public string AcademicTitle { get; set; }

        public string Position { get; set; }

        public Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string position) : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            AcademicTitle = academicTitle;
        }
        public override string ToString()
        {
            return base.ToString() + $"Position:{Position}, AcademicTitle{AcademicTitle}";
        }
    }


}
