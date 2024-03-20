using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    public class Student:Person
    {
        private static int _id;
        public IList<FinalGrade> Grades {  get; set; }
        public int Semestr {  get; set; }
        public int Group {  get; set; }
        public int IndexId { get; set; }
        public string Specialization {  get; set; }
        public double AverageGrades { get; }
        public Student(string firstName, string lastName, DateTime dateOfBirth,  string specialization, int group, int semestr = 1) :base(firstName, lastName, dateOfBirth)
        {
            Semestr = semestr;
            Group = group;
            Specialization = specialization;
        }
        public override string ToString()
        {
            Console.WriteLine($"{base.ToString()} {Semestr} {Group} {Specialization}");
            foreach(FinalGrade finalGrade in Grades)
            {
                if (finalGrade != null)
                {
                    Console.WriteLine(finalGrade.ToString());
                }
            }        
            return "";
        }
    }
}
