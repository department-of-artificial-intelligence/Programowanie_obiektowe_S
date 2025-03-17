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

        public Grade()
        {
            _subjectName="brakNazw";
            _date = new DateTime(0, 0, 0);
            _value = 0;
        }
        public Grade(string subjectName, double value,DateTime date)
        {
            _subjectName = subjectName;
            _date = date;
            _value = value;
        }

        public override string ToString()
        {
            return $"Nazwa: {_subjectName} Data: {_date} Wartosc: {_value} ";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
