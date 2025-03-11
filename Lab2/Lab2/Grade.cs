using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Grade : Student
    {
        protected string _subjectName;
        protected DateTime _date;
        protected double _value;
        public string SubjectName { get { return _subjectName;} set { _subjectName = value; } } 
        public DateTime Date { get { return _date; } set { _date = value; } }   
        public double Value { get { return _value;} set { _value = value; } }   
        public Grade()
        {
            _subjectName = "undefined";
            _date = new DateTime(1,1,1);
            _value = 0;
        }
        public Grade(string subjectName, DateTime Date, double Value)
        {
            _subjectName = subjectName;
            _date = Date;
            _value = Value;
        }
        public override string ToString()
        {
            return $"Subject Name: {SubjectName}, Date: {Date}, Value {Value}";
        }
        public override void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
