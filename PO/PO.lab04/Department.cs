using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab04
{
    public class Department
    {
        public string? Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList <Student> Students { get; set; }
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students) 
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
            return $"Name: {Name}, Dean: \n{Dean} \n OrganizationUnits:" +
                $" {orgaName}\n\n Subjects: {subjectsName}\n\n " +
                $"Students: {studentsName}\n\n";
        }

    }
}
