using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Przygotowanie
{
    internal class Subject
    {

        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semester { get; set; }
        public int HourCount { get; set; }

        public Subject(string name, string specialization, int semester, int hourCount) { 
        
            Name = name;
            Specialization = specialization;
            Semester = semester;
            HourCount = hourCount;
        
        }

        public override string ToString()
        {

            return $"Subject | Name {Name}, Specialization {Specialization}, Semester {Semester}, HourCount {HourCount}";

        }
    }
}
