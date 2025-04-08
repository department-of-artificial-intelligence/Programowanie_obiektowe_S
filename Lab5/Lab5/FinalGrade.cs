using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class FinalGrade
    {
        public Subject Subject { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        

        public FinalGrade(Subject subject, DateTime date, double value)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return $"FinalGrade: Subject: {Subject}, Value: {Value}, Date: {Date}";
        }
    }
}
