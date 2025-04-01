namespace lab4
{
    internal class OrganizationUnit
    {
        private string _name;
        private string _address;
        private IList<Lecturer> _lecturers;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public IList<Lecturer> Lecturers
        {
            get => _lecturers;
            set => _lecturers = value;
        }

        public OrganizationUnit(string name, string adress, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = adress;
            Lecturers = lecturers;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Adress: {Address}, Lecturers: {Lecturers} ";
        }
    }

}
