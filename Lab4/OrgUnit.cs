using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni
{
    public class OrganizationUnit
    {
        public string Name { get; set; }
        public string Adres { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string adres, List<Lecturer> lecturers)
        {
            Name = name;
            Adres = adres;
            Lecturers = lecturers;
        }
    }
}