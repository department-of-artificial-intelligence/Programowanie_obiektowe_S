using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    public class OrganizationUnit:IDisplayable, IContainer
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
            string res=$"Organization Unit: {Name} | {Address} \n With Lecturers: ";
            foreach (var lecturer in Lecturers)
            {
                res+=lecturer.ToString()+'\n';
            }
            return res;
        }
    }
}
