namespace Lab4
{
    public class Department : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
            this.OrganizationUnits = new List<OrganizationUnit>();
        }
        public override string ToString()
        {
            string organizationUnits = string.Join(", ", OrganizationUnits.Select(o => o.ToString()));
            string subjects = string.Join(", ", Subjects.Select(s => s.ToString()));
            string students = string.Join(", ", Students.Select(s => s.ToString()));
            return $"Department | {Name}, {Dean}, {organizationUnits}, {subjects}, {students}\n";
        }
    }
}
