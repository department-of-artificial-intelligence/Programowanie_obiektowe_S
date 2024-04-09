using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab4.Bll
{
    public class Department
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Department(string name, Person dean, IList<Subject> subjects, IList<Student> students)
        {
            Name = name;
            Dean = dean;
            Subjects = subjects;
            Students = students;
            OrganizationUnits = new List<OrganizationUnit>();

        }
        public override string ToString()
        {
            string listaStud = string.Empty;
            string listaSub = string.Empty;
            listaStud += string.Join("\n", Students);
            listaSub += string.Join("\n", Subjects);
            return $"Nazwa: {Name} , Dziekan: {Dean} ,\n Przedmioty : {listaSub} , \n Studenci: {listaStud}  \n  ";
        }
    }
}
