using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student : Person
    {
        protected int _year;
        protected int _group;
        protected int _indexId;
        protected List<Grade> _grades;
        public int Year { get { return _year; } set {  _year = value; } }
        public int Group { get { return _group; } set { _group = value; } } 
        public int IndexId { get { return _indexId;} set { _indexId = value; } }
        public List<Grade> Grades
        {
            get => this._grades;
        }
        public Student()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }
        public Student (string FirstName, string LastName, DateTime DateOfBirth, int Year, int Group, int IndexId)
            :base(FirstName,LastName,DateOfBirth)
        {
            _year = Year;
            _group = Group;
            _indexId = IndexId;
        }
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade ocena = new Grade(subjectName, date, value);
            Grades.Add(ocena);
        }
        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }
        public override string ToString()
        {
            return $"First name: {FirstName}, Last Name: {LastName}, Date of Birth {DateOfBirth}, Year: {Year}, Group: {Group}, Index ID: {IndexId}" ;
        }
    }
}
