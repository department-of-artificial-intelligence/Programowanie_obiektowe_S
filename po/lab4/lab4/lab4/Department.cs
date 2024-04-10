using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Department 
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList <Subject> Subjects { get; set; }
        public IList <Student> Students { get; set; }
        public Department( string name, Person dean, IList<Subject> subjects, IList<Student> students )
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
            OrganizationUnits = new List<OrganizationUnit>();
        }
        public override string ToString()
        {
            string s1 = string.Join(",", OrganizationUnits);
            string s2 = string.Join(",", Subjects);
            string s3 = string.Join(",", Students);

            return $"Name | {Name}, \nDean | {Dean} {s1} \n{s2} \n{s3}";
        }
    }
}
