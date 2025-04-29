namespace Lab4
{
    public class OrganizationUnit : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }
        public override string ToString()
        {
            string lecturers = string.Join(", ", Lecturers.Select(l => l.ToString()));
            return $"OrganizationUnit | {Name}, {Address}, {lecturers}\n";
        }
    }
}
