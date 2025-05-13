using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Grade
    {
        public string Subject {  get; set; }
        public decimal Value { get; set; }

        public Grade(string subject, decimal value) 
        {
            Subject = subject;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Subject}: {Value}";
        }
    }
}
