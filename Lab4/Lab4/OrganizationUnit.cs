using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public OrganizationUnit(string name, string address, IList<Lecturer> lectures)
        {
            Name = name;
            Address = address;
            Lecturers = lectures;// ?? new List<Lecturer>();
        }
        public override string ToString()
        {
            //return $"{Name}, Address: {Address}, Lecturers: {Lecturers.Count}";
            string text = "";

            text += $"Name: {this.Name}, ";
            text += $"Adress: {this.Address}, ";

            text += "Lecturers:\n";
            foreach (Lecturer lecturer in Lecturers)
            {
                text += lecturer.ToString() + "\n";
            }

            return text;
        }
    }
}