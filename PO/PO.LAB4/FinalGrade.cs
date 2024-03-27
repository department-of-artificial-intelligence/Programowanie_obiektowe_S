using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.LAB4
{
    internal class FinalGrade
    {
        public Subject Subject { get; set; } 
        public DateTime Date { get; set; }
        public double Value { get; set; }
        FinalGrade(Subject subject, double value, DateTime date) { }
        public override string ToString() 
        {
            return "";
        }
    }
}
