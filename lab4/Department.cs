using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
<<<<<<< HEAD
    internal class Department : IContainer, IDisplayable
=======
    internal class Department
>>>>>>> c084d9989174665cbdae63b12316673e97fd7bd4
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
<<<<<<< HEAD
                    if (l == null) return res;
=======
>>>>>>> c084d9989174665cbdae63b12316673e97fd7bd4
                    res += l.ToString() + "\n";
                }
            }
            return res;
        }
    }
}
