using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.BLL
{
    public class Grade
    {
        public string Subject { get; set; }
        public float Value { get; set; }
        public int Weight { get; set; }

        public Grade(string subject, float value, int weight)
        {
            Subject = subject;
            Value = value;
            Weight = weight;
        }

        public Grade() {
            Subject = "None";
            Value = 0;
            Weight = 0;
        }
    }
}
