using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;

        public string SubjectName { get { return _subjectName; } set { _subjectName = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public double Value { get { return _value; } set { _value = value; } }

        public Grade(string subjectName = "none", double val = 0.0, DateTime date = default(DateTime))
        {
            _subjectName = subjectName;
            _value = val;
            _date = date;
            
        }
        public override string ToString()
        {
            return $"subject name = {_subjectName}, date = {_date}, value = {_value}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this);
        }


    }
}