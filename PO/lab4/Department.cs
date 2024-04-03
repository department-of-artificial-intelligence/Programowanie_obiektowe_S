using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Department : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            OrganizationUnits = new List<OrganizationUnit>();
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }
        public override string ToString()
        {
            string res = $"Department | Name: {Name}, Dean: {Dean}, SubjectCount: {Subjects.Count}, StudentCount: {Students.Count}\n";
            foreach (var item in Subjects)
            {
                res += item.ToString() + "\n";
            }
            res += "-------------------------------------------------------------------------------------------\n";
			foreach (var item in Students)
			{
				res += item.ToString() + "\n";
			}
			return res;
        }
    }
}
