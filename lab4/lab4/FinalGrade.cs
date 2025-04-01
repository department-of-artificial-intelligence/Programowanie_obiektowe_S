using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni
{
    public class FinalGrade
    {
        public Subject Subject {  get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public FinalGrade(Subject subject, double value, DateTime date)
        {
            Subject=subject;
            Value=value;
            Date=date;
        }
    }
}
