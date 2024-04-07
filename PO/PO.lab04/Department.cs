using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab04
{
    public class Department
    {
        public string? Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
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
            string str = $"Name of Department: {Name} | Dean -> {Dean.ToString()} | Organization Unit : \n";
            if (OrganizationUnits != null)
            {
                int ctrl1 = 1;
                foreach (var ou in OrganizationUnits)
                {
                    str += ctrl1 + ". " + OrganizationUnits.ToString();
                    ctrl1++;
                }
            }
            else
                str += "\nThis Organization Unit doesn't exist";
            if (Subjects != null)
            {
                int ctrl2 = 1;
                foreach (var s in Subjects)
                {
                    str += ctrl2 + ". " + Subjects.ToString();
                    ctrl2++;
                }
            }
            else
                str += "\nSubject doesn't exist";
            if (Students != null)
            {
                int ctrl3 = 1;
                foreach(var S in Students)
                {
                    str += ctrl3 + ". " + Students.ToString();
                    ctrl3++;
                }
            }
            else
                str += "\nStudents doesn't exist";
            return str;
        }
    }
}
