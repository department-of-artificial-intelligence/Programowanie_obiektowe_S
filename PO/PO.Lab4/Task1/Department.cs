using PO.Lab4.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4.Task1
{
    internal class Department: IContainer, IDisplayable
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
            OrganizationUnits = new List<OrganizationUnit>();
            Subjects = subjects;
            Students = students;
        }
        public override string ToString()
        {
            string res = $"{Name} \\ {Dean} \nOrganization units : \n";
            foreach (OrganizationUnit unit in OrganizationUnits)
                res += "\t" + unit + "\n";
            res += "Subjects : \n";
            foreach (Subject unit in Subjects)
                res += "\t" + unit + "\n";
            res += "Students : \n";
            foreach (Student unit in Students)
                res += "\t" + unit + "\n";
            return res;
        }
    }
}
