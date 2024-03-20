using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    public class OrganizationUnit
    {
        public string Name {  get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }
        public override string ToString()
        {
            Console.WriteLine( $"{Name} {Address}");
            foreach (Lecturer l in Lecturers)
            {
                Console.WriteLine( l.ToString() + '\n' );
            }
            return "";
        }
    }
}
