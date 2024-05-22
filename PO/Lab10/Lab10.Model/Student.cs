using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Model
{
    public class Student
    {
        public int Id { get; set; }
        public long StudentIndex { get; set; }
        public string FirstName { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string Faculty { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public IList<Grade> Grades { get; set; } = null!; // właściwość nawigacyjna
        public string AllGrades => Grades.Count > 0 ? string.Join(", ", Grades) : "";
    }
}
