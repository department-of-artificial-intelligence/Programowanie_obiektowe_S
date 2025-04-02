namespace Lab4
{
    public class Subject
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semester { get; set; }
        public int HoursCount { get; set; }

        public Subject(string name, string specialization, int semester, int hourscount)
        {
            Name = name;
            Specialization = specialization;
            Semester = semester;
            HoursCount = hourscount;
        }

        public override string ToString()
        {
            return $"name: {Name}, specialization: {Specialization}, semester: {Semester}, hourscount: {HoursCount}";
        }
    }
}
