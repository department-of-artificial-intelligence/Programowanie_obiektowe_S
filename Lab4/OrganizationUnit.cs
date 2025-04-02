namespace Lab4
{
    public class OrganizationUnit
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; } = new List<Lecturer>();

        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }

        public override string ToString()
        {
            var lecturersString = Lecturers.Any() ? string.Join(", ", Lecturers.Select(l => l.ToString())) : "No lecturers available";
            return $"name: {Name}, address: {Address}, lecturers: {lecturersString}";
        }
    }
}
