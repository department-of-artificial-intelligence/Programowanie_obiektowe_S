using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Bll
{
    public class Student : Person
    {
        private int _year;
        private int _goup;
        private int _indexId;
        private List<Grade> _grades = new List<Grade>();

        public int Year { get { return _year; } set { _year = value; } }
        public int Group { get { return _goup; } set { _goup = value; } }
        public int IndexId { get { return _indexId; } set { _indexId = value; } }

        public List<Grade> IList { get => _grades; }
        public Student() : base()
        {
            _year = 0;
            _goup = 0;
            _indexId = 0;
        }
        public Student(string firstname, string lastname, DateTime dateOfBirth, int year, int group, int indexId) : base(firstname, lastname, dateOfBirth)
        {
            _year = year;
            _goup = group;
            _indexId = indexId;
        }
        public override string ToString()
        {
            string tmp = base.ToString() + $" Year: {_year} , Group: {_goup} , Index id: {_indexId} ";
            foreach (Grade grade in _grades) { tmp += grade.ToString() + "\n"; }
            return tmp;
        }
        public override void Details()
        {
            base.Details();
        }
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            _grades.Add(new Grade(subjectName, value, date));
        }
        public void DisplayGrade()
        {
            foreach (Grade grade in _grades) { Console.WriteLine(grade.ToString()); }
        }
        public void DisplayGrade(string subjectName)
        {
            foreach (Grade grade in _grades)
            {
                if (grade.SubjectName == subjectName)
                {
                    Console.WriteLine(grade.Value);
                }
            }
        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            var grade1 = _grades.FirstOrDefault(a => a.SubjectName == subjectName && a.Value == value && a.Date == date);
            if (grade1 != null) { _grades.Remove(grade1); Console.WriteLine("Udało się usunąć"); } else { Console.WriteLine("Nie udało się!"); }
        }
        public void DeleteGrade(Grade grade) { _grades.Remove(grade); }
        public void DeleteGrades() { _grades.Clear(); }
        public void DeleteGrades(string subjectName) { _grades.RemoveAll(grade => grade.SubjectName == subjectName); }

    }
}
