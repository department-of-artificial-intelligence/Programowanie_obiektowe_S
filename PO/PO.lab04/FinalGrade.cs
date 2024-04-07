using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab04
{
    public class FinalGrade
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set ; }
        public double Value { get; set; }
        public FinalGrade(Subject subjetc, double value, DateTime date) 
        {
            Subject = subjetc;
            Date = date;
            Value = value;
        }
    }
}
