using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private IList<Grade> _grades = new List<Grade>();

        public Student()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) :
                      base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
        }
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

        public override string ToString()
        {
            return base.ToString() +
                    $"Student:| Year: {_year}, Group: {_group}, IndexId: {_indexId} ";
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
            _grades.Add(new Grade(subjectName, value, date));
        }

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void DisplayGrades()
        {
            foreach(var grade in _grades)
            {
                grade.Details();
            }
        }


        public void DisplayGrades(string subjectName)
        {
            foreach (var grade in _grades)
            {
                if (subjectName == grade.SubjectName)
                {
                    grade.Details();
                }
            }
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.Remove(new Grade(subjectName, value, date));
        }

        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }

        public void DeleteGrades(string subjectName)
        {
            for (int i = _grades.Count - 1; i >= 0; i--)
            {
                if (_grades[i].SubjectName == subjectName)
                {
                    _grades.RemoveAt(i);
                }
            }
            Console.WriteLine("Operacja zakonczona");
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }
        

    }
}
