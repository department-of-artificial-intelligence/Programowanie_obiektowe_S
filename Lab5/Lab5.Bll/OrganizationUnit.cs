using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Bll
{
    public class OrganizationUnit
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
            string wyk = string.Empty;
            wyk += string.Join("\n", Lecturers);
            return $"Nazwa wydziału: {Name} , Adres: {Address} \n{wyk}";
        }

    }
}
