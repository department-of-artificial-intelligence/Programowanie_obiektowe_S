using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Department
    {
        private string _name;
        private Person _dean;
        private IList<OrganizationUnit> _organizationUnit;
        private IList<Subject> _subjects;
        private IList<Student> _students;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Person Dean
        {
            get => _dean;
            set => _dean = value;
        }

        public IList<OrganizationUnit> OrganizationUnit
        {
            get => _organizationUnit;
            set => _organizationUnit = value;
        }

        public IList<Subject> Subjects
        {
            get => _subjects;
            set => _subjects = value;
        }

        public IList<Student> Students
        {
            get => _students;
            set => _students = value;
        }

        public Department(string name, Person dean,  IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Dean: {Dean}";
        }

    }
}
