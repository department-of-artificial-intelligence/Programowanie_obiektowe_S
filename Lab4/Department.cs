using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Department : IDisplayable, IContainer
    {
        
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();
        public IList<Subject> Subjects { get; set; } = new List<Subject>();
        public IList<Student> Students { get; set; } = new List<Student>();
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }

        public override string ToString()
        {
            string result = $"Department's Name: {Name}\nDean: {Dean}\n";
            if(OrganizationUnits?.Count > 0)
            {
                result += "Organization Units:\n";
                foreach(var Unit in OrganizationUnits)
                {
                    result += Unit.ToString()+"\n";
                }
            }
            else
            {
                result += "Department doesn't have ORGANIZATION UNITS yet.\n";
            }

            if(Subjects?.Count > 0)
            {
                result += "Subjects:\n";
                foreach(var Subject in Subjects)
                {
                    result += Subject.ToString() + "\n";
                }
            }
            else
            {
                result += "Department doesn't have SUBJECT yet.\n";
            }

            if(Students?.Count > 0)
            {
                result += "Students:\n";
                foreach(var Student in Students)
                {
                    result += Student?.ToString();
                }
            }
            else
            {
                result += "Department doesn't have STUDENTS yet.\n";
            }


            return result;
        }
    }

    

}
