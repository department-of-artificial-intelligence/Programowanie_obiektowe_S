﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Faculty { get; set; }
        public int StudentNo { get; set; }
        public IList<Grade> Grades { get; set; }
        public Student(string firstName,string surName, string faculty, int studentNo) 
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;

        }
        public Student(string firstName, string surName, string faculty, int studentNo,IList<Grade> grades)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;
            Grades = grades;
        }
        public Student() 
        {
            FirstName = "";
            SurName = "";
            Faculty = "";
            StudentNo = 0;

        }
        public override string ToString()
        {
            string g = string.Join(", ", Grades.Select(a=>a.ToString()));
            return $"First Name {FirstName}, Sur Name {SurName}, Faculty {Faculty}, Grades {g}";
        }
    }
}