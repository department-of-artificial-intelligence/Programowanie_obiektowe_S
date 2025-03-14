using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace lab2
{
    internal class Student : Person
    {
        private List<Grade> _grades ;
        private int _year;
        private int _group;
        private int _indexId;

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


        public int IndexID
        {
            get { return _indexId; }
            set { _indexId = value; }
        }
        public Student()
            :base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();
        }
        public Student(string? firstName, string? lastName, DateTime dateTime, int year, int group, int indexId):
            base(firstName, lastName, dateTime)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
            _grades = new List<Grade>();
        }

        public void AddGrade(string? subjectName, double value, DateTime date)
        {
            _grades.Add(new Grade(subjectName, value, date));
        }

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }


        public override string ToString()
        {
            string res = $"Student | {base.ToString()}, Year: {_year}, Group: {_group}, IndexId: {_indexId}";
            foreach (var grade in _grades)
            {
                res += "\t" + grade.ToString() + "\n";
            }
            return res;
        }

        public void DeleteGrade(string? subjectName, double value, DateTime date)
        {
            _grades.Remove(new Grade(subjectName, value, date));
        }
        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }

        public void DeleteGrades(string subjectName)
        {
            //_grades.RemoveAll(delegate (Grade g) {
            //    return g.SubjectName == subjectName;
            //});
            
            _grades.RemoveAll(grade => grade.SubjectName == subjectName);
        }
        public void DeleteGrades()
        {
            _grades.Clear();
        }
    }
}
