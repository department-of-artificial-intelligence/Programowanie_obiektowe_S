using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Department
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
        }
        public override string ToString()
        {
            string temp = $"Name: {Name}, Dean: {Dean}";
            if (OrganizationUnits != null)
            {
                temp += ", OrganizationUnits: \n";
                foreach (OrganizationUnit unit in OrganizationUnits)
                {
                    temp += $"\t{unit}\n";
                }
            }

            if (Subjects != null)
            {
                temp += ", Subjects: \n";
                foreach (Subject subject in Subjects)
                {
                    temp += $"\t{subject}\n";
                }
            }

            if (Students != null)
            {
                temp += ", Students: \n";
                foreach (Student student in Students)
                {
                    temp += $"\t{student}\n";
                }
            }
            return temp;
        }
    }
}
