using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PO
{
    public class Department
    {
        public string Name {  get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Department(string name, Person dean, IList<OrganizationUnit> organizationUnits, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            OrganizationUnits = organizationUnits;
            Subjects = subjects;
            Students = students;
        }
        public override string ToString()
        {
            var str = $"DEPARTMENT: name: {Name} ";
            str += Dean.ToString();
            str += OrganizationUnits.ToString();
            str += Subjects.ToString();
            str += Students.ToString();
            return str;
        }
    }
}
