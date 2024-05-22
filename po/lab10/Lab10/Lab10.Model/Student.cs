using Lab10.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Lab10.Model.Attributes;
using System.Globalization;

namespace Lab10.Model.Entities;

    public class Student
        {
            public int Id { get; set; }
            public long StudentIndex { get; set; }
            public string FirstName { get; set; } = null!;
            public string SurName { get; set; } = null!;
            public string Faculty { get; set; } = null!;
            public DateTime DateOfBirth { get; set; }
            //[Hide]
            public IList<Grade> Grades { get; set; } = null!; // właściwość nawigacyjna
            public string AllGrades => Grades.Count > 0 ? string.Join(", ", Grades) : "";
        }

