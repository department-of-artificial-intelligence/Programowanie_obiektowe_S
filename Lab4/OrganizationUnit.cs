using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class OrganizationUnit
    {
        public string Name
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public IList<Lecturer> Lecturers
        {
            get;
            set;
        }

        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }

        public override string ToString()
        {
            string details = $"OrganizationUnit: | Lecturers:\n";
            foreach (var i in Lecturers)
            {
                details += i.ToString() + ",\n";
            }
            return details + $"Name: { Name}, Address: { Address}";
        }
    }
}
