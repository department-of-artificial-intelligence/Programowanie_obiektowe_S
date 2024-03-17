using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Student:Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> _grades;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public int IndexId
        {
            get { return _indexId; }
            set { _indexId = value; }
        }
        public List<Grade> Grades 
        {
        get { return _grades; }
        }
        public Student()
        {
            _firstName = "nieznane";
            _lastName = "nieznane";
            _DateTime = DateTime.MinValue;
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();

        }
        public Student(string firstName, string lastName, DateTime dateofBirth, int year, int group, int indexId)
        {
            _firstName = firstName;
            _lastName = lastName;
            _DateTime = dateofBirth;
            _year = year;
            _group = group;
            _indexId = indexId;
            _grades = new List<Grade>();
        }
        public override string ToString()
        {
            DisplayGrades();
            return $"Imie: {_firstName} | Nazwisko {_lastName} | Data urodzenia {_DateTime} | rok {_year} | grupa {_group} | nr indeksu {_indexId}";
        }
        public void AddGrade(string subjectName,double value,DateTime date)
        { 
         _grades.Add(new Grade(subjectName,value,date));
        }
        public void AddGrade(Grade grade) 
        {
        _grades.Add(grade);
        }
        public void DisplayGrades() 
        {
            foreach (var item in _grades)
            {
                Console.WriteLine(item);
            }
        }
        public void DisplayGrades(string subjectName) 
        {
        
        foreach (var grade in _grades) 
            {
                if (grade.SubjectName == subjectName)
                    {
                   Console.WriteLine(grade);
                }
            }
        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
          _grades.RemoveAll(grade=>grade.SubjectName==subjectName &&  grade.Value==value && grade.Date==date);
        }
        public void DeleteGrade(Grade grade) 
        {
            _grades.Remove(grade);
         
        }

        public void DeleteGrades(string subjectName)
        {
         _grades.RemoveAll(grade=>grade.SubjectName==subjectName);
        }
            public void DeleteGrades() 
        {
            _grades.Clear();
        }
    }
}
