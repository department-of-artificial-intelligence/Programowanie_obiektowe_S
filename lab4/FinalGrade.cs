using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    internal class FinalGrade : IDisplayable
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
            return $" FinalGrade | Subject: {Subject.ToString}, Date: {Date}, Value: {Value} ";
        }
    }
}
