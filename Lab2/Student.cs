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
        private List<Grade> _grades = new List<Grade>();
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
        public Student()
        {
            _year = 0000;
            _group = 0;
            _indexId = 0;
        }

        public Student(string firstName, string lastName, DateTime birthDate, int year, int group, int indexId)
            : base(firstName, lastName, birthDate)
        {
            _year = year;
            _group = group;
            _indexId = indexId;
        }

        public override void Details()
        {
            base.Details();
            Console.WriteLine($"Year: {_year}, GPA: {_group}, Student ID: {_indexId}");
        }

        public void AddGrade(string subject, double value, DateTime date)
        {
            _grades.Add(new Grade(subject, value, date));
        }

        public void DisplayGrades()
        {
            foreach (var grade in _grades)
                Console.WriteLine(grade);
        }

        public override string ToString()
        {
            return base.ToString() + $", Year: {_year}, GPA: {_group}, Student ID: {_indexId}";
        }
    }
}
