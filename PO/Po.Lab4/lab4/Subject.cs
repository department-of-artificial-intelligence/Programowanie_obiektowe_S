namespace lab4
{
    public class Subject
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semester { get; set; }
        public int HourstCount { get; set; }

        public Subject()
        {
            Name = "nieznane";
            Specialization = "nieznana";
            Semester = 0;
            HourstCount = 0;
        }
        public Subject(string name, string specialization, int semester, int hourstCount)
        {
            Name = name;
            Specialization = specialization;
            Semester = semester;
            HourstCount = hourstCount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Specialization: {Specialization}, Semster: {Semester},Hours count: {HourstCount}";
        }
    }
}
