using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4
{
    public class OrganizationUnit
    {
        public string Name { get; set; }
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
            string zwrotny =  $"Name: {Name}, Addres {Address}," ;
            foreach (var l in Lecturers)
            {
                zwrotny += "\n";
                zwrotny += l.ToString();

            }
            return zwrotny;
        }
    }
}
