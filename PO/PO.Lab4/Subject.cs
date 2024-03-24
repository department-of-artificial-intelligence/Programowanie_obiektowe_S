using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4
{
    public class Subject
    {
        public string Name {  get; set; }
        public string Specialization { get; set; }
        public int Semestr {  get; set; }
        public int HourCount {  get; set; }
        public Subject(string name, string specialization, int semestr, int hourCount)
        {
            Name = name;
            Specialization = specialization;
            Semestr = semestr;
            HourCount = hourCount;
        }
        public override string ToString()
        {
            Console.WriteLine($"Name: {Name}, Specialization: {Specialization}, Semestr: {Semestr}, HourCount: {HourCount}");
            return "";
        }
    }
}
