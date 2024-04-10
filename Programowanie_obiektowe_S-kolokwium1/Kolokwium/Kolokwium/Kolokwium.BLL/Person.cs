using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium.BLL
{
    public abstract class Person : IInfo
    {
        public string Name { get; set; }
        public string LastName {  get; set; }
        public Person(string FName, string LName)
        {
            Name = FName;
            LastName = LName;
        }
        public override string ToString()
        {
            return $"{Name} | {LastName}";
        }
        public virtual void Display()
        {
            Console.WriteLine(this);
        }
    }
}