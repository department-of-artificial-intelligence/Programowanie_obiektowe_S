using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Bll
{
    public class OrganizationUnit
    {

        public string Name { get; set; }
        public string Adress { get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string adress, IList<Lecturer> lecturers)
        {
            Name = name;
            Adress = adress;
            Lecturers = lecturers;
        }



        public override string ToString()
        {
            string lista = string.Empty;
            lista += string.Join('\n', Lecturers);
            return $"Nazwa: {Name} , Adres: {Adress} , Wykladowcy:\n {lista}\n";
        }
    }
}
