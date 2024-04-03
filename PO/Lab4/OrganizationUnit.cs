using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lab5
{
    public class OrganizationUnit
    {
        public string Name {get; set;}
        public string Address { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public OrganizationUnit(string name, string address, List<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }

        public override string ToString()
        {
            string result= "OrganizationUnit | Name: " + Name + ", Address: " + Address + "\nLecturers:";
            Lecturers.
            foreach( Lecturer lec in Lecturers)
            {
                result+= "\n" + lec.ToString();
            }
            return result;
        }
    }
}
