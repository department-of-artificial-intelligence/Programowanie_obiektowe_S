using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.app
{
    internal class Subject
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semestr { get; set; }
        public int HoursCount { get; set; }

        public Subject(string name, string specialization, int semestr, int hoursCount)
        {
            Name = name;
            Specialization = specialization;
            Semestr = semestr;
            HoursCount = hoursCount;
        }

        public override string ToString()
        {
            return $"Name: {Name} Specialization: {Specialization} Semestr: {Semestr} Hours Count: {HoursCount}";
        }
    }
}
