using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab4
{
    internal class OrganizationUnit
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string address, 
            IList<Lecturer> lecturers) { 
        
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }
        public override string ToString()
        {
            string itemsName = string.Join(", ", Lecturers.Select(a => a.ToString()));
            return $"Name: {Name}, Address: {Address}, " +
                $"Lecturers: {Lecturers}";
        }
    }
}
