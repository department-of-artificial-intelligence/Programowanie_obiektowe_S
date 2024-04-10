using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.app
{
    internal class Department
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }

        public Department(string name, Person dean, IList<OrganizationUnit> organizationUnits, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            OrganizationUnits = new List<OrganizationUnit>();
            Subjects = subjects;
            Students = students;
        }
        public override string ToString()
        {
            string s = new string($"Department | Name: {Name} Dean: {Dean} Organization Units: \n");
            foreach ( var item in OrganizationUnits )
            {
                s += item.ToString() + "\n";
            }
            s += "Subjects: \n";
            foreach (var item in Subjects)
            {
                s += item.ToString() + "\n";
            }
            s += "Students: \n";
            foreach (var item in Students)
            {
                s += item.ToString() + "\n";
            }
            return s;
        }
    }
}
