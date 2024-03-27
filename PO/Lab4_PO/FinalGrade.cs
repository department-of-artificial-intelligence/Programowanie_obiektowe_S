using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PO
{
    public class FinalGrade
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public FinalGrade(Subject subject, double value, DateTime date) 
        {
            Subject = subject;
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return $"Subject: {Subject}, date: {Date}, value: {Value}\n";
        }
    }
}
