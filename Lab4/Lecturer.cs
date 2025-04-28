namespace Lab4
{
    public class Lecturer : Person, IContainer, IDisplayable
    {
        public string AcademicTitle { get; set; }
        public string Position { get; set; }
        public Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string position) : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }
        public override string ToString()
        {
            return base.ToString() + $"Lecturer | {AcademicTitle}, {Position}\n";
        }
    }

}