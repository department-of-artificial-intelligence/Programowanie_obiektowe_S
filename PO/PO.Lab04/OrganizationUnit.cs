namespace PO.Lab04
{
    internal class OrganizationUnit
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
            return $"OrganizationUnit | Name: {Name}, Address: {Address}, Lecturers: {Lecturers}";
        }
    }
}
