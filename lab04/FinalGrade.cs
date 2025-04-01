using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class FinalGrade
    {
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public FinalGrade (Subject subject, double valeue, DateTime date)
        {
            Subject = subject;
            Date = date;
            Value = valeue; 
        }

        public override string ToString()
        {
            return Subject.ToString() +
                $"FinalGrade | Date: {Date}, Value: {Value}\n";
        }
    }
}
