using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Department
    {
        public string Name { get; set; }
        public Person Dean {  get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students) { 
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;

        }

        public override string ToString()
        {
            string lista1 = string.Join(", ", Subjects.Select(s => s.ToString()));
            string lista2 = string.Join(", ", Students.Select(s => s.ToString()));
            //string lista3 = string.Join(", ", OrganizationUnits.Select(s => s.ToString()));
            return $"Name: {Name}, Dean: {Dean}, Subjects:{lista1}, Students: {lista2}\n";
        }
    }
}
