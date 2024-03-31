using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    internal class Department
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits {get; set;}
        public IList<Subject> Subjects { get; set;}
        public IList<Student> Students { get; set;}
        public Department(string name, Person dean,IList<Subject> subjects, IList<Student> students) 
        {
        Name= name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
     
        }
        public override string ToString()
        {
            
            string subjectString = string.Join(", ", Subjects.Select(Subject => Subject.ToString()));
            string studentsString = string.Join("\n", Students.Select(Student => Student.ToString()));
            return $"DEPARTMENT | Name {Name}\n Subjects \n {subjectString} Students \n {studentsString}";
        }
    }
   
}
