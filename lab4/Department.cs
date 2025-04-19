using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Department:IContainer, IDisplayable
    {     
        public string Name { get; set; }

        public Person Dean { get; set; }

        public IList<OrganizationUnit>? OrganizationUnits { get; set; }=new List<OrganizationUnit>();

        public IList<Subject> Subjects { get; set; }

        public IList<Student> Students { get; set; }


        public Department(string name, Person dean,  IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }

        public override string ToString()
        {
            string outcome = $"Name: {Name}, Dean: {Dean}";

            outcome += "\nOrganization units:\n";
            if (OrganizationUnits != null)
            {
                foreach (var organiationUnit in OrganizationUnits)
                {
                    outcome += organiationUnit + "\n";
                }
            }

            outcome += "\nSubjects:\n";
            if (Subjects != null)
            {
                foreach (var subject in Subjects)
                {
                    outcome = outcome + subject + "\n";
                }
            }

            outcome += "\nStudents:\n";
            if (Students != null)
            {
                foreach (var student in Students)
                {
                    outcome = outcome + student + "\n";
                }
            }

            return outcome;
        }

    }
}
