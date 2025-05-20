using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.BLL
{
    public class Grade
    {
        public string Subject { get; set; }
        public double Score { get; set; }
        public DateTime Date { get; set; }

        public Grade(string subject, double score, DateTime date)
        {
            Subject = subject;
            Score = score;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Subject}: {Score}, {Date.ToShortDateString()}";
        }
    }
}
