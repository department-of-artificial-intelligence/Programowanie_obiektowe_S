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
        public double GradeS { get; set; }
        public int Weight { get; set; }
        public Grade()
        {
            NameSubject = "";
            GradeS = 0;
            Weight = 0;
        }
        public Grade(string nameSubject, double gradeS,int weight)
        {
            NameSubject = nameSubject;
            GradeS = gradeS;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Name Subject {NameSubject}, Weight {Weight}, Grade {GradeS}";
        }
    }
}
