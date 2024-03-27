using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.LAB4
{
    internal class Subject
    {
        public string Name {  get; set; }
        public string Specialization { get; set; }
        public int Semestr {  get; set; }
        public int HoursCount {  get; set; }
        Subject(string name, string specialization, int semestr, int hoursCount)
        {
            Name = name;
            Specialization = specialization;
            Semestr = semestr;
            HoursCount = hoursCount;
        }
        public override string ToString() 
        {
            return "";
        }
    }
}
