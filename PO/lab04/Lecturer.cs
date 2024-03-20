
namespace lab04
{
    public class Lecturer : Person
    {
        public string AcademicTitle { get; set; }
        public string Position { get; set; }
        public Lecturer(string firstName, string lastName, DateTime birth,
                        string title, string position)
            : base(firstName, lastName, birth)
        {
            AcademicTitle = title;
            Position = position;
        }
    }
}
