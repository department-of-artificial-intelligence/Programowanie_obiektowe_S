namespace lab4
{
    public class Lecturer : Person
    {
        public string AcademicTitle { get; set; }
        public string Position { get; set; }

        public Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string position)
        : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth}, Academic: {AcademicTitle}, Position: {Position} \n";
        }
    }
}
