namespace lab4
{
    public class OrganizationUnit: IContainer, IDisplayable
    {
        
        public string Name { get; set; }


        public string Address { get; set; }


        public IList<Lecturer> Lecturers { get; set; }


        public OrganizationUnit(string name, string adress, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = adress;
            Lecturers = lecturers;
        }

        public override string ToString()
        {
            string temp = "";
            foreach (var item in Lecturers)
            {
                temp += item.ToString()+" || ";
            }
            return $"Name: {Name}, Adress: {Address}, Lecturers: {temp} ";
        }
    }

}
