using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Department : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }// = new List<Subject>();
        public IList<Student> Students { get; set; }// = new List<Student>();
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects; //?? new List<Subject>();
            Students = students; //?? new List<Student>();
            this.OrganizationUnits = new List<OrganizationUnit>();
        }
        public override string ToString()
        {
            //return $"Department: {Name}, Dean: {Dean.FirstName} {Dean.LastName}";
            string text = "";

            text += $"Name: {this.Name}\n";
            text += $"Dean: {this.Dean}\n";

            text += "OrganizationUnits:\n";
            this.OrganizationUnits.ToList().ForEach(organizationUnit => text += organizationUnit + "\n");

            text += "Subjects:\n";
            this.Subjects.ToList().ForEach(subject => text += subject + "\n");

            text += "Students:\n";
            this.Students.ToList().ForEach(student => text += student + "\n");

            return text;
        }
    }
}
