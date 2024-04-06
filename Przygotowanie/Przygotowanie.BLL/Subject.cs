using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie.BLL
{
    public class Subject : IInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Subject(string name) 
        {
            Name = name;
        }

        public Subject(string name, string description) : this(name)
        {
            Description = description;
        }

        public override string ToString()
        {
            var str = $"Name: {Name}, Description: {Description}";
            return str;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
