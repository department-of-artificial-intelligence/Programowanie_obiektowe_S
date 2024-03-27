using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab4
{
    internal class Department
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        
        public IList<Subject> Subjects { get; set; }

        public IList<Student> Students { get; set; }
        public Department(string name, Person dean, IList<Subject> subjects,
            IList<Student> students) 
        { 
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }

        public override string ToString()
        {
            string subjectsName = string.Join(", ", Subjects.Select(a => a.ToString()));
            string studentsName = string.Join(", ", Students.Select(a => a.ToString()));
            string? orgaName = OrganizationUnits != null ? string.Join(", ", OrganizationUnits.Select(a => a.ToString())) : "";
            return $"Name: {Name}, Dean: {Dean}, OrganizationUnits:" +
                $" {orgaName}, Subjects: {subjectsName}, " +
                $"Students: {studentsName}";
        }
    }
}
