using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Bll
{
    public class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;

        public string SubjectName { get { return _subjectName; } set { _subjectName = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public double Value { get { return _value; } set { _value = value; } }

        public Grade() { _subjectName = string.Empty; _date=DateTime.Now ; _value = 0.0; }
        public Grade(string name, double val , DateTime date) {
            _subjectName = name;
            _date = date;
            _value = val;
        }
        public override string ToString()
        {
            string tmp = base.ToString() + $" Nazwa przedmiotu: {_subjectName} , Data: {_date}, Ocena: {_value}.";
            return tmp;
        }
        public void Details() { Console.WriteLine(this.ToString()); }
    }
}
