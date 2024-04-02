using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PO
{
    public class Department : IContainer
    {
        public string Name {  get; set; }
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
            string s1 = string.Join(", ", OrganizationUnits);
            string s2 = string.Join(", ", Subjects);
            string s3 = string.Join(", ", Students);
            return $"Name: {Name}, Dean: {Dean} \n {s1} \n {s2} \n {s3}";

            //var str = $"DEPARTMENT: name: {Name} \n";
            //str += Dean.ToString();
            //str += OrganizationUnits.ToString();
            //str += Subjects.ToString();
            //str += Students.ToString();
            //return str;
        }
    }
}
