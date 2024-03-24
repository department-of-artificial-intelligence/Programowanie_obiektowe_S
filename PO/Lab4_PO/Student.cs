using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PO
{
    public class Student : Person
    {
        private static int id;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1)
        :base(firstName, lastName, dateOfBirth)
        {
            Semester = semester;
            Specialization = specialization;
            Group = group;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"Semester: {Semester}, group: {Group}, specialization: {Specialization} ";
            str += string.Join<FinalGrade>('\n', Grades);
            return str;
        }
    }
}
