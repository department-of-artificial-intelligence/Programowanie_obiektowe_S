using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Bll
{
    public class Subject
    {
        public string Name { get; set; }
        public string Specjalization { get; set; }
        public int Semester { get; set; }
        public int HoursCount { get; set; }
        public Subject(string name, string specjalization, int semster, int hoursCount)
        {
            Name = name;
            Specjalization = specjalization;
            HoursCount = semster;
            HoursCount = hoursCount;
        }
        public override string ToString()
        {
            return $"Nazwa przedmiotu: {Name} , Specjalizacja: {Specjalization}, Ilosc godzin:{HoursCount}";
        }
    }
}
