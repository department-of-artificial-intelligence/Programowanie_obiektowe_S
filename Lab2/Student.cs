using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student : Person
    {
        int _year;
        int _group;
        int _indexId;
        List<Grade> _grades;

        public int Year {  get { return _year; } set { _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int IndexId { get { return _indexId;} set { _indexId = value; } }
        public List<Grade> Grades
        {
            get => _grades;
        }
        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
        }
        public override string ToString()
        {
            return base.ToString()+$", Year: {_year}, Group: {_group}, IndexId: {_indexId}";
        }
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            _grades.Add(new Grade(subjectName, value, date));
        }
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.Remove(new Grade(subjectName, value, date));
        }
        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }
        public void DisplayGrade()
        {
            foreach(var grade in _grades)
            {
                grade.Details();
            }
        }
        public void DisplayGrade(string subjectName)
        {
            foreach (var grade in _grades)
            {
                if(grade.SubjectName == subjectName) grade.Details();
            }
        }
    }
}
