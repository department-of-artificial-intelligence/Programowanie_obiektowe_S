using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab04
{
    internal class OrganizationUnit
    {
        

        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }

        public OrganizationUnit(string name, string address, IList<Lecturer> lectures)
        {
            Name = name;
            Address = address;
            Lecturers = lectures;
        }

        public override string? ToString()
        {
            return $"Name: {Name}, Address: {Address}, Lecturers: {Lecturers}";
        }
    }
}
