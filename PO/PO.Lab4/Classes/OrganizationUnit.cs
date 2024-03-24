using Lab4.App;

namespace PO.Lab4.Classes
{
    public class OrganizationUnit: IContainer, IDisplayable
    {
        public string Name { get; set; }

        public string Address { get; set; }
        public IList<Lecturer> Lectures { get; set; }

        public OrganizationUnit(string name, string address, IList<Lecturer> lectures)
        {
            Name = name;
            Address = address;
            Lectures = lectures;
        }

        public override string ToString()
        {
            string res = $"{Name} , {Address} , Lecturers : ";
            foreach (var item in Lectures)
                res += "\t" + item + "\n";
            return res;
        }
    }


}
