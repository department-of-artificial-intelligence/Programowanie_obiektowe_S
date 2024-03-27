using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    internal class FinalGrade 
    {
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public FinalGrade(string subject, DateTime date, double value)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }
        public override string ToString() 
        {
        return $"FINAL GRADE | Subject {Subject} Date {Date} Value {Value}";
        }

    }
}
