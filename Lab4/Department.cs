namespace Lab4
{
    public class Department
    {
        public string Name { get; set; }
        public Person Dean { get; set; }

        public IList<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();
        public IList<Subject> Subjects { get; set; } = new List<Subject>();
        public IList<Student> Students { get; set; } = new List<Student>();

        public Department(string name, Person dean, IList<OrganizationUnit> organizationUnits, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            OrganizationUnits = organizationUnits;
            Subjects = subjects;
            Students = students;
        }

        public override string ToString()
        {
            var organizationunitsString = OrganizationUnits.Any() ? string.Join(", ", OrganizationUnits.Select(g => g.ToString())) : "No organization units";
            var subjectsString = Subjects.Any() ? string.Join(", ", Subjects.Select(g => g.ToString())) : "No subjects";
            var studentsString = Students.Any() ? string.Join(", ", Students.Select(g => g.ToString())) : "No students";
            return $"name: {Name}, dean: {Dean}, OrganizationUnits: {organizationunitsString}, subjects: {subjectsString}, students: {studentsString}";
        }
    }
}
