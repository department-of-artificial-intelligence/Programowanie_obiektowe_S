using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab04
{
    internal class FinalGrade
    {
        
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public FinalGrade(Subject subject, DateTime date, double value)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }

        public override string? ToString()
        {
            return $"\tSubject: {Subject}, Date: {Date}, Value: {Value}";
        }
    }
}
