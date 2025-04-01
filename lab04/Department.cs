using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Department
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }

        public Department(string name, Person person, IList<Subject> subjects, IList<Student> students) 
        {
            Name = name;
            Dean = person;
            Subjects = subjects;
            Students = students;
        }

        public override string ToString() 
        {
            string organizationUnit = "OrganizationUnit | ";
            foreach(OrganizationUnit unit in OrganizationUnits) organizationUnit += unit.ToString();

            string subjects = "Subjects | ";
            foreach(Subject subject in Subjects) subjects += subject.ToString();

            string students = "Students";
            foreach (Student student in Students) students += student.ToString();

            return $"Departments | Name: {Name}, Dean: {Dean}\n" + organizationUnit + subjects + students + "\n";
        }
    }
}
