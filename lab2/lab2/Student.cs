using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> _grades;

        public int Year { get => _year; set => _year = value; }
        public int Group { get => _group; set => _group = value; }
        public int IndexId { get => _indexId; set => _indexId = value; }
        public List<Grade> Grades { get => _grades; }

        public Student() : base()
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
            return base.ToString() + $" Year: {_year}, Group: {_group}, Index Id: {_indexId}  ";
        }
        public override void Details()
        {
            Console.WriteLine(ToString());
            DisplayGrades();
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade grade = new Grade(subjectName, date, value);
            _grades.Add(grade);
        }
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }
        public void DisplayGrades()
        {
            Console.WriteLine($"Grades:");
            foreach (var grade in _grades)
            {
                Console.WriteLine(grade);
            }
        }
        public void DisplayGrades(string subjectName)
        {
            Console.WriteLine($"Grades {subjectName}:");
            foreach (var grade in _grades.Where(o => o.SubjectName == subjectName))
            {
                Console.WriteLine(grade);
            }
        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            Grade? grade = _grades.FirstOrDefault(g => g.SubjectName == subjectName && g.Value == value && g.Date == date);//new Grade(subjectName, date, value);
            if (grade != null)
                _grades.Remove(grade);
        }
        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }
        public void DeleteGrades()
        {
            _grades.Clear();
        }
        public void DeleteGrades(string subjectName)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName);
        }

    }
}
