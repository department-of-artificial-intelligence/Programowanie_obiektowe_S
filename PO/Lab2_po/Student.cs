 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_po
{
    public class Student: Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> _grades = new List<Grade>();

        public int Year { get { return _year; } set { _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int IndexId { get { return _indexId; } set { _indexId = value; } }

        public Student()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) 
        : base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;            
            _indexId = indexId;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $" year: {_year}, group: {_group}, index: {_indexId}";
            return str; 
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade grade = new Grade();
            grade.SubjectName = subjectName;
            grade.Value = value;
            _grades.Add(grade);
        }

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void DisplayGrade()
        {
            foreach (var grade in _grades)
            {
                Console.WriteLine(this);
            }
        }

        public void DisplayGrades(string subjectName)
        {

        }

        public void DeleteGrade(string subjectName, double value, DataSetDateTime date)
        {

        }

        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }

        public void DeleteGrades(string subjectName)
        {
                var foundedGrade = _grades.Where(b => b.SubjectName == subjectName);
               
                foreach (var grade in foundedGrade) { _grades.Remove(grade); }
        }
    }
}
