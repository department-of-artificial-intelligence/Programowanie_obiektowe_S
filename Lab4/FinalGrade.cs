using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class FinalGrade
    {
        public Subject Subject{get; set;}
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public FinalGrade( Subject subject  , double val = 0.0, DateTime date = default(DateTime))
        {
            Subject = subject;
            Value = val;
            Date = date;
        }

        public override string ToString()
        {
            return $"subject: {Subject}, date: {Date}, val: {Value}";
        }
    }
}
