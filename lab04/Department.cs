using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class Department
    {
        public string Name { get; set; }

        public Person Dean { get; set; }

        public IList<OrganizationUnit> Organizations { get; set; }

        public IList<Subject> Subjects { get; set; }

        public IList<Student> Students { get; set; }
        
        public Department() { }

        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }

        public override string ToString()
        {
            return $" Name: {Name}, Dean: {Dean}, Subjects: {Subjects} and Students: {Students}";
        }




    }
}
