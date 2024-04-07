using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab04
{
    public class OrganizationUnit
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer>? Lecturers { get; set; }
        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers)
        {
            Name = name;
            Address = address;
            Lecturers = lecturers;
        }
        public override string ToString()
        {
            string str = $"Name of Organization Unit: {Name} | Address of Organization Unit: {Address} | Lecturers list: \n";
            if (Lecturers != null)
            {
                int ctrl = 1;
                foreach (var l in Lecturers)
                { 
                    str += ctrl + ". " + l.ToString() + '\n';
                    ctrl++;
                }
            }
            else
                str += $"There's is not Lecturers in {Name}";
            str += "\n\n";
            return str;
        }
    }
}
