using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Grade
    {
        public string? Subject { get; set; }
        public float? Mark { get; set; }

        public Grade() : this("Null", 0.0f) { }
        public Grade(string? subject, float? mark)
        {
            Subject = subject;
            Mark = mark;
        }
    }
}
