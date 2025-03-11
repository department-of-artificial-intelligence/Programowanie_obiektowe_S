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

        public int Year { get { return _year; } set { _year = value; } }
        public int Group { get { return _group;} set { _group = value; } }
        public int IndexId { get { return _indexId;} set { _indexId = value; } }

        public Student() : base() 
        { 
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth,  int year, int group, int indexId) : base(firstName, lastName, dateOfBirth) 
        {
            _year = year;
            _group = group;
            _indexId = indexId;
            _grades = new List<Grade>();
        }

        public override string ToString() 
        { 
            //return $"Student | FirstName: {_firstName}, LastName: {_lastName}, DateOfBirth: {_dateOfBirth}, Year: {_year}, Group: {_group}, IndexId: {_indexId}";
            string temp =  $"Student | {base.ToString()}, Year: {_year}, Group: {_group}, IndexId: {_indexId}";

            if (_grades.Count > 0) temp += ", Grades: \n";

            foreach (Grade grade in _grades)
            {
                temp += "\t" + grade.ToString() + "\n" ;
            }

            return temp;
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
            foreach (Grade grade in _grades)
            {
                Console.WriteLine(grade);
            }
        }

        public void DisplayGrades(string subjectName)
        {
            Console.WriteLine(_grades.Where(grade => grade.SubjectName == subjectName));
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.Remove(new Grade(subjectName, value, date));
        }

        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }

        public void DeleteGrades(string subjectName) {
            _grades.RemoveAll(grade => grade.SubjectName == subjectName);
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }
    }
}
