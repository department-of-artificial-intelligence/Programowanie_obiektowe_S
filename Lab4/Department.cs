using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Department
    {
        public string Name
        {
            get;
            set;
        }

        public Person Dean
        {
            get;
            set;
        }

        public IList<OrganizationUnit> OrganizationUnits
        {
            get;
            set;
        }

        public IList<Subject> Subjects
        {
            get;
            set;
        }

        public IList<Student> Students
        {
            get;
            set;
        }

        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }

        public override string ToString()
        {
            string details = $"Department: | OrganizationUnits:\n";
            //foreach (var i in OrganizationUnits)
                //details += i.ToString() + ",\n";
            return details + $"Name: {Name}, Dean: {Dean}, ";
        }
    }
}
