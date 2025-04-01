using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Subject
    {
        private string _name;
        private string _specalization;
        private int _semester;
        private int _hoursCount;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Specalization
        {
            get => _specalization;
            set => _specalization = value;
        }

        public int Semester
        {
            get => _semester;
            set => _semester = value;
        }

        public int HoursCount
        {
            get => _hoursCount;
                set => _hoursCount = value;
        }

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
