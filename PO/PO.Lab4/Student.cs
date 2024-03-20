using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab4
{
    public class Student : Person
    {
        private static int _id;
        
        public IList<FinalGrade> Grades
        {
            get;set;
        }
        public int Semestr {  get; set; }
        public int Group { get; set; }
        public string Specialization { get; set; }
        public int IndexId {  get; set; }
        public double AverageGrades { get;}
        public Student (string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semestr = 1)
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group; 
            Semestr = semestr;
        }
        public override string ToString()
        {
            string str = "";
            foreach (FinalGrade item in Grades)
            {
                if (item != null)
                    str += item.ToString() + '\n';
            }
            return base.ToString() + $"Semestr: {Semestr}, Group: {Group}, Specialization: {Specialization}, IndexId: {IndexId}, AverageGrades: {AverageGrades},'\n' Grades: " + str;
        }
    }
}
