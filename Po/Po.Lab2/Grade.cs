using System;
using Po.Lab2;
namespace Po.Lab2
{
    public class Grade 
    {
        private string _subjectName;
        private DateTime? _date;
        private double _value;

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

        public Grade()
        {
            _subjectName = null;
            _date = null;
            _value = "";
        }
        public Grade(string subjectName, double value, DateTime date)
        {
            _subjectName ??= subjectName;
            _date = date;
            _value = value;
        }
        public override string ToString()
        {
            return $"Subject Name: {_subjectName}, Date: {_date}" +
                $", Value: {_value}";
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
