using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Student : Person
    {
        public int Id =1;
        public List<FinalGrade> Grades { get; set; }
        public int Semestr {  get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get;}

        public Student(int id, string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semestr ) 
            :base(firstName, lastName, dateOfBirth)
        {
            Id = id;
            Specialization = specialization;
            Group = group;
            Semestr = semestr;
        }

        public override string ToString()
        {
            return $"Student: | " + base.ToString() + $"Specialization: {Specialization}, Group: {Group}, Semestr: {Semestr}";
        }
    }
}
