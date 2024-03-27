using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    internal class OrganizationUnit
    {
        public string Name
        {
            get; set;
        }

        public string Address { get; set; }
        public IList<Lecturer> Lectures { get; set; }
        public OrganizationUnit(string name,string address,IList<Lecturer> lecturers) 
        {
            Name = name;
            Address = address;
            Lectures = lecturers;
        }
        public override string ToString() 
        {
            return $"ORGANIZATION UNIT| Name {Name} Address {Address} Lectures {Lectures}";
        }
    }
}
