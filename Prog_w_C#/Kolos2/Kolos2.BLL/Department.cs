using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos2.BLL
{
    public class Department
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> ogranizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }    
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            ogranizationUnits = new List<OrganizationUnit>();
            Subjects = subjects;
            Students = students;
        }
        public override string ToString() 
        {
            string sub = string.Empty;
            string stud = string.Empty;
            sub += string.Join("\n", Subjects);
            stud += string.Join("\n", Students);

            return $"{Name} \nDziekan:\n{Dean} \nPrzedmioty:\n{sub} \nStudenci:\n{stud}";
        }
    }
}
