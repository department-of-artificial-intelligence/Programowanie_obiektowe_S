using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Subject
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semester { get; set; }
        public int HoursCount { get; set; }
        public Subject(string name = "none", string specialization = "none", int semester = -1, int hoursCount = -1)
        {
            Name = name;
            Specialization = specialization;
            Semester = semester;
            HoursCount = hoursCount;
        }

        public override string ToString()
        {
            return $"name = {Name}, specialization = {Specialization}, semester = {Semester}, hours = {HoursCount}";
        }

    }
}
