using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Subject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Subject(string name)
        {
            Name = name;
        }
        public Subject(string name, string description) 
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} {Description}";
        }

        public void Display ()
        {
            Console.WriteLine(ToString());
        }
    }
}
