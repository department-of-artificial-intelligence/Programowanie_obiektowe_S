using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Bll
{
    public class FinalGrade
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public FinalGrade(Subject subject, double value, DateTime dateTime)
        {
            Subject = subject;
            Value = value;
            Date = dateTime;
        }
        public override string ToString()
        {
            return $"Przedmiot: \n {Subject} ,  Ocena: {Value} , Data: {Date}  \n";
        }
    }
}
