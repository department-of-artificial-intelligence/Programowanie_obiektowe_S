using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab04
{
    public class Subject
    {
        public string Name { get => Name; set => Name = value; }
        public string Specialization{ get => Specialization; set => Specialization = value; }
        public int Semester { get => Semester; set => Semester = value; }
        public int HoursCount {  get => HoursCount; set => HoursCount = value; }
        public Subject(string name, string specialization, int semester, int hoursCount) 
        {
            Name = name;
            Specialization = specialization;
            Semester = semester;
            HoursCount = hoursCount;
        }
        public override string ToString()
        {
            return $"Name: {Name} | Specialization {Specialization} | Sumeseter: {Semester} | Count of Hours: {HoursCount}";
        }
    }
}
