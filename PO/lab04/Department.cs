namespace lab04
{
    public class Department : IContainer
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Department(string name, Person dean,
            IList<Subject> subj, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subj;
            Students = students;
        }
        public override string ToString()
        {
            return $"{Name}; {Dean};";
        }
    }
}
