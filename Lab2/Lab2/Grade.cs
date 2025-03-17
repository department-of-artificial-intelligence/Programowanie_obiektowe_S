using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    public class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;
        public string SubjectName
        {
            get => _subjectName; set => _subjectName = value;
        }
        public DateTime Date
        {
            get => _date; set => _date = value;
        }
        public double Value
        {
            get => _value; set => _value = value;
        }
        public Grade()
        {
            _subjectName = "none";
            _value = 0.0;
            _date = default;
        }
        public Grade(string subjectName, double value, DateTime date)
        {
            SubjectName = subjectName;
            Date = date;
            Value = value;
        }
        public override string ToString()
        {
            return $" {SubjectName} {Date.ToShortDateString()} {Value}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}