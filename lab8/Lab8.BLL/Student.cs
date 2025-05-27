using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Faculty { get; set; }
        public int? ID { get; set; }

        public IList<Grade>? JoinedGrades { get; set; }
        public Student() : this("Null", "Null", 0, "Null", null) { }
        public Student(string? imie, string? nazwisko, int? numerIndeksu, string? wydzial, IList<Grade>? grades)
        {
            FirstName = imie;
            LastName = nazwisko;
            ID = numerIndeksu;
            Faculty = wydzial;
            JoinedGrades = grades;
        }
    }
}
