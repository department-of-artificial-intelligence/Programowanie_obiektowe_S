using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni
{
    public class Department
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public List<OrganizationUnit> Organizations { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }
        public Department(string name, Person dean, List<Subject> subjects, List<Student> students)
        {
            Name=name;
            Dean = dean;
            
            Subjects=subjects;
            Students=students;
            Organizations=new List<OrganizationUnit>();
        }
    }
}
