using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class OrganizationUnit
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Lecturer> Lecturers { get; set; }

        public OrganizationUnit(string name, string addres, IList<Lecturer> lecturers) 
        {
            Name = name;
            Address = addres;
            Lecturers = lecturers;
        }

        public override string ToString() 
        {
            string temp = "";
            foreach(Lecturer lecturer in  Lecturers) 
            {
                temp += lecturer.ToString();
            }

            return $"OrganizationUnit | Name: {Name}, Addres: {Address} Lecturers: " + temp + "\n";
        }
    }
}
