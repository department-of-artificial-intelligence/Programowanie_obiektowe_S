using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab04
{
    public class FinalGrade
    {
        public Subject Subject { get => Subject; set => Subject = value; }
        public DateTime Date { get => Date; set => Date = value; }
        public double Value { get => Value; set => Value = value; }
        public FinalGrade(Subject subjetc, double value, DateTime date) 
        {
            Subject = subjetc;
            Date = date;
            Value = value;
        }
    }
}
