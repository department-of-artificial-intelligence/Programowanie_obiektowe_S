namespace lab04
{
    public class Subject
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semester { get; set; }
        public int HoursCount { get; set; }
        public Subject(string name, string spec, int sem, int hours)
        {
            Name = name;
            Specialization = spec;
            Semester = sem;
            HoursCount = hours;
        }
    }
}
