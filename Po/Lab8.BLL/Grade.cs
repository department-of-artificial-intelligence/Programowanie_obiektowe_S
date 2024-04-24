using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Grade
    {
        public string NameSubject { get; set; }
        public float GradeS { get; set; }
        public int Weight { get; set; }
        public Grade()
        {
            NameSubject = null;
            GradeS = 0;
            Weight = 0;
        }
        public Grade(string nameSubject, float gradeS,int weight)
        {
            NameSubject = nameSubject;
            GradeS = gradeS;
            Weight = weight;
        }
    }
}
