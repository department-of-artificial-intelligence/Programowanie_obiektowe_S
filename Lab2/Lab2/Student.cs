using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> _grades;
        public int Year { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public List<Grade> Grades
        {
            get { return _grades; } //returns a reference
        }
        public Student()
            : base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
            : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
            _grades = new List<Grade>();
        }
        public override string ToString()
        {
            string gradesString = "";
            foreach (var grade in _grades)
            {
                gradesString += grade.ToString() + " ";
            }
            return base.ToString() + $" {Year} {Group} {IndexId} {gradesString}";
        }
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade grade = new Grade(subjectName, value, date);
            _grades.Add(grade);
        }
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }
        public void DisplayGrades()
        {
            if (_grades.Count == 0)
            {
                Console.WriteLine("The student has no grades.");
            }
            else
            {
                Console.WriteLine("Student's grades:");
                foreach (var grade in _grades)
                {
                    Console.WriteLine(grade);
                }
            }
        }
        public void DisplayGrades(string subjectName)
        {
            var foundedGrades = _grades.Where(g => g.SubjectName.Equals(subjectName, StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundedGrades.Count == 0)
            {
                Console.WriteLine($"Student has no grades in subject: {subjectName}.");
            }
            else
            {
                Console.WriteLine($"Student's grades in subject: {subjectName}:");

                foreach (var grade in foundedGrades)
                {
                    Console.WriteLine(grade);
                }
            }
        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName && g.Value == value && g.Date == date);
        }
        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }
        public void DeleteGrades(string subjectName)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName);
        }
        public void DeleteGrades()
        {
            _grades.Clear();
        }
    }
}