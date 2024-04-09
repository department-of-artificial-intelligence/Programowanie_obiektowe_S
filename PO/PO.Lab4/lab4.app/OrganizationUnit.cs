using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.app
{
    internal class OrganizationUnit
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
            string s = new string($"Organization Unit | Name: {Name} Address: {Address} Lecturers: \n");
            foreach (var item in Lecturers)
            {
                s += item.ToString();
            }
            return s;
        }
    }
}
