namespace PO.lab04
{
    public class OrganizationUnit
    {
        public string Name { get => Name; set => Name = value; }
        public string Address { get => Address; set => Address = value; }
        public IList<Lecturer> Lecturers { get => Lecturers; set => Lecturers = value; }
        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }
        public override string ToString()
        {
            string a = $"Name: {Name}| Address: {Address}";
            foreach (Lecturer l in Lecturers)
            {
                a += l.ToString();
            }
            return a;
        }
    }
}
