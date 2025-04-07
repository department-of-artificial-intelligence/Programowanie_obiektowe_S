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
        public IList<OrganizationUnit> OrganizationUnits { get; set; }=new List<OrganizationUnit>();
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Department(string name ,Person dean,IList<Subject> subjects,IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
        }
        public override string ToString()
        {
            string orgunits = "";
            foreach (OrganizationUnit orgunit in OrganizationUnits) { orgunits += orgunit.ToString(); }
            string sub = "";
            foreach (Subject subject in Subjects) { sub += subject.ToString(); }
            string stud = "";
            foreach (Student student in Students) { stud += student.ToString(); }
            return $"Department Nazwa: {Name} Dziekan: {Dean} Organization Units: {orgunits} Przedmioty: {sub} Studenci: {stud}" + "\n";
        }



    }
}
