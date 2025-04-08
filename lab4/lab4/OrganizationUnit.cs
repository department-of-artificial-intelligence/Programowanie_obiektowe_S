using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class OrganizationUnit : IContainer, IDisplayable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }

        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers ?? new List<Lecturer>();
        }

        public override string ToString()
        {
            string lecturersStr = Lecturers != null && Lecturers.Count > 0
                ? string.Join("\n ", Lecturers)
                : "Brak wykladowcow";
            return $"Organization Unit: {Name}, {Address}, \n {lecturersStr}";
        }
    }
}
