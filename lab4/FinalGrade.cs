using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class FinalGrade
    {
        private Subject _subject;
        private DateTime _date;
        private double _value;

        public Subject Subject
        {
            get => _subject;
            set => _subject = value;
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

        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject = subject;
            Value = value;
            Date = date;
        }

        public override string ToString()
        {
            return $"Subject: {Subject}, Value: {Value}, Date: {Date} ";
        }
    }
}
