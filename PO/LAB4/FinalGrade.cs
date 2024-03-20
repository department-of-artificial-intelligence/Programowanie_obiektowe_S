using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_LAB4
{
    public class FinalGrade
    {
        public Subject Subject {  get; set; }
        public DateTime Date { get; set; }
        public double Value {  get; set; }
        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }
        public override string ToString()
        {
            return $"Final Grade: {Subject.ToString()} | {Date} | {Value}";
        }
    }
}
