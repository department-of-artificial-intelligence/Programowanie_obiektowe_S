using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Grade
    {
        private string _subject { get; }
        private double _value { get; }
        private DateTime _date { get; }

        public Grade(string subject, double value, DateTime date)
        {
            _subject = subject;
            _value = value;
            _date = date;
        }
        public Grade() 
        {
            _subject = "Unknown";
            _value = 0;
            _date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{_subject}: {_value} ({_date.ToShortDateString()})";
        }

        public override void Details() 
        {
            base.Details();
            Console.WriteLine($"Subject: {_subject}, Value: {_value}, Date: {_date}");
        }


    }
}
