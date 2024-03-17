using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Grade
    {
        private string _subjectname;
        private DateTime _date;
        private double _value;
        public string SubjectName
        {
            get {  return _subjectname; }
            set { _subjectname = value; }
        }
        public DateTime Date 
        {
        get {return _date; }
            set { _date = value; }
        }
        public double Value 
        {
            get { return _value; }
            set { _value = value; }
        }
        public Grade() 
        {
            _subjectname = "nieznany";
            _date = DateTime.Now;
            _value = 0;
        }
        public Grade(string Subjectname, double value, DateTime date)
        {
            _subjectname = Subjectname;
            Value = value;
            Date = date;
            
        
        }
        public override string ToString()
        {
            return $"Ocena{_value} z {_subjectname} data {_date}";
        }
        public void Details() 
        {
            Console.WriteLine(this);
        }
         
    }
}
