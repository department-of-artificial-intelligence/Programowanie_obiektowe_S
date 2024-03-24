using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4
{
    public class Department : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList <Subject> Subjects { get; set; }
        public IList <Student> Students { get; set; }
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
            OrganizationUnits = new List<OrganizationUnit>();
        }
        public override string ToString()
        {
            /*string str = "Organization Units: ";
            foreach (OrganizationUnit unit in OrganizationUnits)
            {
                str += unit.ToString() + " ";
            }*/
            Console.WriteLine($"Name: {Name}, Dean : " + Dean.ToString());
            Console.WriteLine("Subjects: ");
            foreach (Subject subject in Subjects)
            {
                Console.WriteLine(subject.ToString());
            }
            Console.WriteLine("Students: ");
            foreach (Student stud in Students)
            {
                Console.WriteLine(stud.ToString());
            }
            return "";
        }
    }
}
