using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class OrganizationUnit : IContainer
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
            string s1 = $"Name: {Name}, Address: {Address} \n ";
            string s2 = string.Join(", ", Lecturers);
            return s1+s2;
        }
    }
}
