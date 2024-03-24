using PO.Lab4.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4.Task1
{
    internal class OrganizationUnit:IContainer,IDisplayable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set;}
        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }
        public override string ToString()
        {
            string res = $"{Name} \\ {Address} \\ Lecturers : \n";
            foreach (var item in Lecturers)
                res += "\t\t" + item+"\n";
            return res;
        }
    }
}
