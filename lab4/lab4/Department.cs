using lab4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Department : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects ?? new List<Subject>();
            Students = students ?? new List<Student>();
        }

        public override string ToString()
        {
            string subjectStr = Subjects != null && Subjects.Count > 0
                ? string.Join("\n ", Subjects)
                : "Brak przedmiotów";
            string studentsStr = Students != null && Students.Count > 0
                ? string.Join("\n ", Students)
                : "Brak przedmiotów";
            return $"Department: {Name}, \n {Dean}, \n {subjectStr}, \n {studentsStr}";
        }
    }
}

