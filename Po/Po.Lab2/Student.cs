using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Po.Lab2
{
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> grades = new List<Grade>();

        public int Year { get => _year; set => _year = value; }
        public int Group { get => _group; set => _group = value; }
        public int IndexId { get => _indexId; set => _indexId = value; }
        public List<Grade> IList { get => grades;}

        public Student()
        {
            _group = 0;
            _year = 0;
            _indexId = 0;
        }
        public Student(string firstName, string lastName, DateTime birthDate, int year,
            int group, int indexId) : base(firstName, lastName, birthDate)
        {
            _group = group;
            _indexId = indexId;
            _year = year;
        }
        public override string ToString()
        {
            return base.ToString() + $"Year: {_year}, Group: {_group}" +
                $", Index: {_indexId}";
        }
        public override void Details()
        {
            base.Details();
        }
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            grades.Add(new Grade(subjectName, value, date));
        }
        public void AddGrade(Grade grade)
        {
            grades.Add(grade);
        }
        public void DisplayGrade()
        {
            foreach(Grade grade in grades)
            { 
                Console.WriteLine(grade.ToString());
            }
        }

    }


}

