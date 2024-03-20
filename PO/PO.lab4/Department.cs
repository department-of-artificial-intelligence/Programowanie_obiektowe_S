using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    public class Department
    {
        public string Name {  get; set; }  
        Person Dean { get; set; }
        IList<OrganizationUnit> OrganizationUnits { get; set; }
        IList<Subject> Subjects {  get; set; }
        IList<Student> Students { get; set; }
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }
        public override string ToString()
        {
            Console.WriteLine( $"{Name} {Dean}");
            foreach(Subject s in Subjects)
            {
                Console.WriteLine(s.ToString());
            }
            foreach(Student s in Students)
            {
                Console.WriteLine(s.ToString());
            }
            return "";
        }
    }
}
