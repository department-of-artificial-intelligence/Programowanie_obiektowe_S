using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Grade
    {
        protected string _subjectName;
        protected DateTime _date;
        protected double _value;
        public string SubjectName
        {
            get => _subjectName;
            set => _subjectName = value;
        }
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }
        public double Value
        {
            get => _value;
            set => _value = value;
        }
        public Grade(string subjectName, double value, DateTime date)
        {
            SubjectName = subjectName;
            Value = value;
            Date = date;
        }
        public void Details()
        {
            Console.WriteLine($"Grade: {ToString()}");
        }
        public override string ToString()
        {
            return $"{SubjectName}; {Value}; {Date.ToShortDateString()};";
        }
    }
}
