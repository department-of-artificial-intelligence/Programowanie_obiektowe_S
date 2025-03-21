using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;

        public string SubjectName { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public Grade()
        {
            _subjectName = "none";
            _date = DateTime.MinValue;
            _value = 0.0;
        }
        public Grade(string subjectName, double value, DateTime date)
        {
            _subjectName= subjectName;
            _date = date;
            _value = value;
        }

        public override string ToString() => $"Grade| Subject name: {_subjectName}, Date: {_date}, Value: {_value} \n";
        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}
