using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class OrganizationUnit
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        
        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers) { 
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }

        public override string ToString()
        {
            string lista1 = string.Join(", ", Lecturers.Select(s => s.ToString()));
            return $"Name: {Name}, Address: {Address}, Lecturer: {lista1}\n";
        }
    }
}
