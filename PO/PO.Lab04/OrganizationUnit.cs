namespace PO.Lab04
{
    internal class OrganizationUnit : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }

        public OrganizationUnit(string name, string address, IList<Lecturer> lectures)
        {
            Name = name;
            Address = address;
            Lecturers = lectures;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var l in Lecturers)
            {
                str += "\n   ";
                str += l.ToString();

            }
            return $"Organization Unit | Name: {Name}, Address: {Address}, Lecturers: {str}";
        }
    }
}
