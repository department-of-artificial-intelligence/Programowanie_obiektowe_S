using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Przygotowanie
{
    internal class Department : IContainer, IDisplayable
    {

        public string Name { get; set; }
        public Person Dean { get; set; }

        public IList<OrganizationUnit>? OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }

        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students) { 
        
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;



        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Department Name {Name}");
            sb.AppendLine($"Person: {Dean}");

            sb.AppendLine($"Subjects:");
            foreach ( var subject in Subjects ) {

                sb.AppendLine(subject.ToString());
            
            }

            sb.AppendLine($"Students:");
            foreach( var student in Students )
            {

                sb.AppendLine(student.ToString());

            }

            return sb.ToString();

        }

    }
}
