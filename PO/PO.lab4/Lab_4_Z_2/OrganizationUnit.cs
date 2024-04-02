using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Przygotowanie
{
    internal class OrganizationUnit : IContainer, IDisplayable
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }

        public OrganizationUnit(string name, string address, IList<Lecturer> lecturers) { 
        
            Name = name;
            Address = address;
            Lecturers = lecturers;

        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Address: {Address}");
            sb.AppendLine($"Lecturers:");

            foreach (var lecturer in Lecturers) {


                sb.AppendLine(lecturer.ToString());
            
            
            }

            return sb.ToString();

        }

    }
}
