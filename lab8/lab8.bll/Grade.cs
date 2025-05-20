using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.bll
{
    public class Grade
    {
        public string Subject { get; set; }
        public int Mark {  get; set; }

        public Grade(string subject, int mark)
        {
            Subject = subject;
            Mark = mark;
        }

        public Grade() 
        {
            Subject = "none";
            Mark = 0;
        }
    }
}
