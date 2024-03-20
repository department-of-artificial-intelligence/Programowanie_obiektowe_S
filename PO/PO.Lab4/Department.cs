using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4
{
    public class Department
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
        }
        public override string ToString()
        {
            /*string str = "Organization Units: ";
            foreach (OrganizationUnit unit in OrganizationUnits)
            {
                str += unit.ToString() + " ";
            }*/
            string str = "";
            str += "Subjects: ";
            foreach (Subject subject in Subjects) 
            {
                if (subject != null)
                str += subject.ToString() + " ";
            }
            str += '\n' + "Students: ";
            foreach (Student subject in Students)
            {
                    if(subject != null)
                    str += Students.ToString() + " ";
            }
            return $"Name: {Name}, Dean : "+ Dean.ToString() + " " + str;
        }
    }
}
