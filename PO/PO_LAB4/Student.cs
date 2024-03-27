using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_LAB4
{
    public class Student : Person
    {
        private static int _id;

        public IList<FinalGrade> FinalGrades { get; set; }
        public int Semester {  get; set; }
        public int Group {  get; set; }
        public int IndexId { get; set; }
        public string Specialization {  get; set; }
        public double AverageGrades { get;}
        public Student(string FName, string LName, DateTime DOB, string specialization, int group, int semester = 1) : base(FName, LName, DOB)
        {
            Semester = semester;
            Group = group;
            Specialization = specialization;
        }
        public override string ToString()
        {
            Console.WriteLine($"Student: {base.ToString()} ON Semester {Semester} | IN Group {Group} | {IndexId} | {Specialization} | {AverageGrades}, with grades: ");
            if (FinalGrades != null)
            {
                foreach (var grade in FinalGrades)
                {
                    Console.WriteLine($"{grade}");
                }
            }
            return "";
        }
    }
}
