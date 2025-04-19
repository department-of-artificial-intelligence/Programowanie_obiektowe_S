using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Subject: IDisplayable, IContainer
    {    
        public string Name { get; set; }
        public string Specalization { get; set; }
        public int Semester { get; set; }
        public int HoursCount { get; set; }


        public Subject(string name, string specalization, int semester, int hoursCount)
        {
            Name = name;
            Specalization = specalization;
            Semester = semester;
            HoursCount = hoursCount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Specalization: {Specalization}, Semester: {Semester}, HoursCount: {HoursCount} ";
        }

    }
}
