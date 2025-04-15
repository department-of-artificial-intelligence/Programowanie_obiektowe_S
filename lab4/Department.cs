using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Department : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();
        public IList<Subject> Subjects { get; set; } = new List<Subject>();
        public IList<Student> Students { get; set; } = new List<Student>();
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }
        public override string ToString()
        {
            string res = $" Department | Name: {Name}, Dean: {Dean} ";
            if (OrganizationUnits != null)
            {
                foreach (var l in OrganizationUnits)
                {
                    res += l.ToString() + "\n";
                }
            }
            if (Subjects != null)
            {
                foreach (var l in Subjects)
                {
                    res += l.ToString() + "\n";
                }
            }
            if (Students != null)
            {
                foreach (var l in Students)
                {
                    if (l == null) return res;
                    res += l.ToString() + "\n";
                }
            }
            return res;
        }
    }
}
