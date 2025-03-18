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

        public Grade()
        {
            _subjectName = "brak";
            _date = default(DateTime);
            _value = 0.0;
        }

        public Grade(string subjectName, double value, DateTime date)
        {
            _subjectName = subjectName;
            _date = date;
            _value = value;
        }

        public string SubjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override string ToString()
        {
            return base.ToString() +
                    $"Grade | SubjectName: {_subjectName}, Date: {_date}, Value: {_value}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
