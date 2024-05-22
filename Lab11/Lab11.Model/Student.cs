using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//using Lab11.Model.Attributes;

namespace Lab11.Model.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public long StudentIndex { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Faculty { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IList<Grade>Grades { get; set; }
        public string AllGrades => Grades.Count > 0 ? string.Join(", ", Grades) : "";

    }
}
