using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class FinalGrade : IDisplayable
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject = subject;
            Value = value;
            Date = date;
        }
        public override string ToString()
        {
            //return $"{Subject.Name}, Grade: {Value}, Date: {Date.ToShortDateString()}";
            return $"Subject: {this.Subject}, " +
                   $"Date: {this.Date}, " +
                   $"Value: {this.Value}";
        }
    }
}
