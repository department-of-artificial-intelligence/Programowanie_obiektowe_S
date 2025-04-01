using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class OrganizationUnit
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string adress, IList<Lecturer> lecturers) { 
            
            Name = name;
            Adress = adress;
            Lecturers = lecturers;

        }

        public override string ToString()
        {
            return $"--------OrganizationUnit| Name: {Name}, Adress: {Adress}, Lecturers: {Lecturers}";
        }

    }
}
