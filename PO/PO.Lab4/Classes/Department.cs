using Lab4.App;

namespace PO.Lab4.Classes
{
    public class Department: IContainer, IDisplayable
    {
        public string Name { get; set; }

        public Person Dean { get; set; }

        public IList<OrganizationUnit> OrganizationUnits { get; set; }

        public IList<Subject> Subjects { get; set; }

        public IList<Student> Students { get; set; }

        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            
                Name = name;
                Dean = dean;
                Subjects = subjects;
                Students = students;
                OrganizationUnits = new List<OrganizationUnit>();

            
        }
        public override string ToString()
        {
            string res = $"{Name}, {Dean}";
            foreach (var unit in OrganizationUnits)
            {
                res += "\t" + unit + "\n";
            }
            foreach (var subject in Subjects)
            {
                res += "\t" + subject + "\n";
            }
            foreach (var student in Students)
            {
                res += "\t" + student + "\n";
            }

            return res;
        }
    }


}
