using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private IList<Grade> _grades = new List<Grade>();

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

        public IList<Grade> Grades
        {
            get { return _grades; }
        }

        public Student() : base()
        {
            Year = 0;
            Group = 0;
            IndexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
        }

        public override string ToString()
        {
            string details = $"Student | Year = {Year}, Group = {Group}, IndexId = {IndexId} Grades:\n";
            if(_grades != null)
            {
                foreach (Grade i in _grades)
                    details += i.ToString();
            }
            details += base.ToString();
            return details;
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade grade = new Grade(subjectName, value, date);
            _grades.Add(grade);
        }

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void DisplayGrades()
        {
            if (_grades != null)
            {
                Console.WriteLine("Grades |");
                foreach (Grade i in _grades)
                    Console.WriteLine(i.ToString());
            }
            else
                Console.WriteLine("Brak ocen.");
        }

        public void DisplayGrades(string subjectName)
        {
            if (_grades != null)
            {
                var grades = _grades.Where(f => f.SubjectName == subjectName);
                if (grades != null)
                {
                    Console.WriteLine("Grades |");
                    foreach (Grade i in grades)
                        Console.WriteLine(i.ToString());
                }
                else
                    Console.WriteLine("Brak ocen.");
            }
            else
                Console.WriteLine("Brak ocen.");
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            Grade? grade = _grades.FirstOrDefault(f => (f.SubjectName == subjectName && f.Value == value && f.Date == date));
            if (grade != null)
                _grades.Remove(grade);
            else
                Console.WriteLine("Nie odnaleziono szukanej oceny.");
        }

        public void DeleteGrade(Grade grade)
        {
            if(!(_grades.Remove(grade)))
                Console.WriteLine("Nie odnaleziono szukanej oceny.");
        }

        public void DeleteGrades(string subjectName)
        {
            var grades = _grades.Where(f => f.SubjectName == subjectName);
            if (grades != null)
            {
                foreach (Grade i in grades.ToList())
                    _grades.Remove(i);
            }
            else
                Console.WriteLine($"Nie odnaleziono ocen dla {subjectName}.");
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }
    }
}
