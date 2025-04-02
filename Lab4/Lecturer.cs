namespace Lab4
{
    public class Lecturer : Person
    {
        public string AcademicTitle { get; set; }
        public string Position { get; set; }

        public Lecturer(string firstname, string lastname, DateTime dateofbirth, string academictitle, string position)
            : base(firstname, lastname, dateofbirth)
        {
            AcademicTitle = academictitle;
            Position = position;
        }

        public override string ToString()
        {
            return base.ToString() + $" academic title: {AcademicTitle}, position: {Position}";
        }
    }
}
