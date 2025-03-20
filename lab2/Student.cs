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
        private int _indexID;
        private List<Grade> _grades;


        public int Year { get { return _year; } set {  _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int IndexID { get { return _indexID; } set { _indexID = value; } }
        public List<Grade> Grades { get { return _grades; } }


        public Student(string firstName = "none", string lastName = "none", DateTime dateOfBirth = default(DateTime), int year = 999,
                        int group = 999, int indexID = 999)
        :base(firstName, lastName, dateOfBirth)
        {
            _year = year;
            _group = group;
            _indexID = indexID;
            _grades = new List<Grade>();
        }
        public override string ToString()
        {
            string gradesInfo = _grades.Count > 0
            ? string.Join(", ", _grades)
        : "No grades";
            return $"{base.ToString()}, year = {_year}, group = {_group}, index = {_indexID} , grades: {gradesInfo}";
        }
        
        public void AddGrade(string subjectName, double val, DateTime date)
        {
            _grades.Add(new Grade(subjectName, val, date));
        }

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }

        public void DisplayGrade()
        {
            foreach(var grade in _grades)
            {
                Console.WriteLine(grade);
            }
        }

        public void DisplayGrades(string subjectName)
        {
            var subjectGrades = _grades.Where(g => g.SubjectName == subjectName);

            if (subjectGrades.Any())
            {
                foreach (var grade in subjectGrades)
                {
                    Console.WriteLine(grade);
                }
            }
            else
            {
                Console.WriteLine("nie znaleziono ocen");
            }
        }

        public void DeleteGrade(string subjectName, double val, DateTime date)
        {
            var gradeToRemove = _grades.FirstOrDefault(g => g.SubjectName == subjectName  && g.Date == date && g.Value == val);
            if (gradeToRemove != null)
            {
                _grades.Remove(gradeToRemove);
            }
        }

        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }

        public void DeleteGrades(string subjectName)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName);
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }



    }
}
