namespace Lab4
{
    public class Subject :IContainer, IDisplayable
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semester { get; set; }
        public int HoursCount { get; set; }
        public Subject(string name, string specialization, int semester, int hoursCount)
        {
            Name = name;
            Specialization = specialization;
            Semester = semester;
            HoursCount = hoursCount;
        }
        public override string ToString()
        {
            return $"Subject | {Name}, {Specialization}, {Semester}, {HoursCount}\n";
        }
    }
}
