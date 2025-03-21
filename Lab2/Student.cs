using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            set { _grades = value; }
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
            _grades = new List<Grade> ();
        } 
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade grade = new Grade(subjectName, value, date);
            _grades.Add(grade);
        }

        public override string ToString()
        {
            string result = base.ToString() + $"Student| Year: {_year}, Group: {_group}, IndexId: {_indexId} \n";
            foreach (Grade grade in _grades)
            {   
                result += grade.ToString() + " " ;
            }
            return result ;
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName && g.Value == value && g.Date == date);
        }

        public void DeleteGrades(string subjectName)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName);
        }

        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }
        
        public void DeleteGrades()
        {
            _grades.Clear();
        }


    }
}
