using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class OrganizationUnit
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
            string result = $"Unit's Name: {Name}, Address: {Address}";
            if(Lecturers?.Count > 0)
            {
                result += "\nLecturer's List:\n";
                foreach(var Lecturer in Lecturers)
                {
                    result += Lecturer.ToString() + "\n";
                }
            }
            else
            {
                result += "\n";
            }

            return result;
        }
    }
}
