namespace PO.Lab4.Classes
{
    public class Subject
    {
        public string Name { get; set; }

        public string Specialization { get; set; }

        public int Semester { get; set; }

        public int HoursCount { get; set; }
        public Subject(string name, string specialization, int semestr, int hoursCount)
        {

            Name = name;
            Specialization = specialization;
            Semester = hoursCount;
            HoursCount = hoursCount;

        }
        public override string ToString()
        {
            return $"{Name}, {Specialization}, {Semester}, {HoursCount}";
        }
    }


}
