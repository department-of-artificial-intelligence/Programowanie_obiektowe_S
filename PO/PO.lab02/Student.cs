using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PO.lab02
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _index;
        private List<Grade> _grades;
        public int Year { get => _year; set => _year = value; }
        public int Group { get => _group; set => _group = value; }
        public int Index { get => _index; set => _index = value; }
        public List<Grade> Grades
        {
            get { return _grades; }
        }
        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _index = 0;
            _grades = new List<Grade>();
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int index) : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _index = index;
            _grades = new List<Grade>();
        }
        public override string ToString()
        {
            string a = base.ToString() + $" | Year: {_year} | Group: {_group} | Index no: {_index}";
            foreach(Grade g in _grades)
                a += g.ToString();
            return a;
        }
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade a = new Grade(subjectName, value, date);
            _grades.Add(a);
        }
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }
        public void DisplayGrades()
        {
            foreach(Grade g in _grades)
            {
                Console.WriteLine(g.ToString() + "\n");
            }
        }
        public void DisplayGrades(string subjectName)
        {
            foreach (Grade g in _grades)
            {
                if(g.SubjectName == subjectName)
                    Console.WriteLine(g.ToString() + "\n");
            }
        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            for(int i = 0; i < _grades.Count; i++)
            {
                if (_grades[i].SubjectName == subjectName)
                {
                    if (_grades[i].Value == value)
                    {
                        if (_grades[i].Date == date)
                            _grades.RemoveAt(i);
                    }
                }
            }
        }
        public void DeleteGrade(Grade grade) 
        {
            for (int i = 0; i < _grades.Count; i++)
            {
                if (_grades[i] == grade)
                {  _grades.RemoveAt(i);}
            }
        }
        public void DeleteGrades() 
        {
            _grades.Clear();
        }
        public void DeleteGrades(string subjectName)
        {
            for(int i = 0; i < _grades.Count; i++)
            {
                if (_grades[i].SubjectName.Equals(subjectName))
                    _grades.RemoveAt(i);
            }
        }
    }
}
