using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.app
{
    internal class FinalGrade
    {
        public Subject Subject { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }


        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }
        public override string ToString()
        {
            return $"Final Grade | Subject: {Subject} Date: {Date} Value {Value}";
        }
    }
}
