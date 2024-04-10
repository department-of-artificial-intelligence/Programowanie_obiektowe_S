using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    public class Department: IContainer, IDisplayable
    {
        public string Name {  get; set; }  
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects {  get; set; }
        public IList<Student> Students { get; set; }
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
            string res=$"Department: {Name} Dean{Dean} and Subjects: ";
            foreach (var sub in Subjects)
            {
                res+=sub.ToString()+'\n';
            }
            foreach (var std in Students)
            {
                res+=std.ToString() + '\n';
            }
            foreach (var org in OrganizationUnits)
            {
                res += org.ToString() + '\n';
            }
            return res;
        }
    }
}
