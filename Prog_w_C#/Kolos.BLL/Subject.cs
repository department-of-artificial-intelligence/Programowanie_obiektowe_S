using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos.BLL
{
    public class Subject
    {
        public string Name { get; set; }
        public string Specjalization { get; set; }
        public int Semester {  get; set; }
        public int HoursCount { get; set; }
        public Subject(string name, string specjalization, int semester, int hoursCount)
        {
            Name = name;
            Specjalization = specjalization;
            Semester = semester;
            HoursCount = hoursCount;
        }
        public override string ToString() 
        {
            return $" Nazwa: {Name}, Specjalizacja: {Specjalization} , Semster: {Semester} , Ilosc_godz: {HoursCount}";
        }
    }
}
