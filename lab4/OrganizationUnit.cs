using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class OrganizationUnit
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; } = new List<Lecturer>();

        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }

        public override string ToString()
        {
            string zwrot = $"{Name}, {Address}, Lecturers: ";

            if (Lecturers != null)
            {
                foreach (var lecturer in Lecturers)
                {
                    zwrot += " " + lecturer; 
                }
            }
            return zwrot;
        } 
    }
}
