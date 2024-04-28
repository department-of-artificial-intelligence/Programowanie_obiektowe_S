using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Grade
    {
        public float Value {  get; set; }
        public string Subject { get; set; }

        public Grade(float value, string subject)
        {
            Value = value;
            Subject = subject;
        }

        public Grade() 
        {
            Value = 0;
            Subject = "None";
        }

        public override string ToString()
        {
            var str = $"Grade: {Value}, Subject: {Subject}";
            return str;
        }
    }
}
