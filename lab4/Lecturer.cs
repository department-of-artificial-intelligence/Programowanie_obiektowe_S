namespace lab4
{
    internal class Lecturer : Person
    {
        private string _academicTitle;
        private string _position;

        public string AcademicTitle
        {
            get => _academicTitle;
            set => _academicTitle = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public Lecturer(string firstName, string lastName,
            DateTime dateOfBirth, string academicTitle, string position) : base(firstName, lastName, dateOfBirth)
        {
            AcademicTitle = academicTitle;
            Position = position;
        }

        public override string ToString()
        {
            return base.ToString() + $" AcademicTitle: {AcademicTitle}, Position: {Position}";
        }
    }
}
