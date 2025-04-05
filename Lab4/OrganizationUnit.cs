using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class OrganizationUnit : IContainer, IDisplayable
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
            string outcome = $"Name: {Name}, Address: {Address}, ";
            outcome += "Lecturers:\n";
            
            foreach(var lecturer in Lecturers) {
                outcome = outcome + lecturer + "\n";
            }

            return outcome;
        }
    }
}
