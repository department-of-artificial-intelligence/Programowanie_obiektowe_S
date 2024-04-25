using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName {  get; set; }
        public string SurName { get; set; }
        public string Faculty {  get; set; }
        public int StudentNo {  get; set; }
        public double AverageGrade { get {
				if (Grades.Count == 0)
				{
					return 0; 
				}
				double sum = Grades.Sum(grade => grade.Value);
				double average = sum / Grades.Count;

				return Math.Round(average, 2);
			} set { } }
        public IList<Grade> Grades { get; set; }
        public Student()
        {
            StudentNo = 0;
            FirstName = string.Empty;
            SurName = string.Empty;
            Faculty = string.Empty;
            Grades = new List<Grade>();
        }

        public Student(string firstName, string surName, string faculty, int studentNo, IList<Grade> grades)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;
            Grades = grades;
        }
    }
}
