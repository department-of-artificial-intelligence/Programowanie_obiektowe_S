namespace lab04
{
    public class OrganizationUnit
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string addr, IList<Lecturer> lecs)
        {
            Name = name;
            Address = addr;
            Lecturers = lecs;
        }
        public override string ToString()
        {
            return $"{Name}; {Address};";
        }
    }
}
