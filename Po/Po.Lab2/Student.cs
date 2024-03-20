using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Po.Lab2;

namespace Po.Lab3
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
            string result = base.ToString() + $"Year: {_year}, Group: {_group}" +
                $", Index: {_indexId}, Grades:\n";

            foreach (Grade grade in grades)
            {
                result += grade.ToString() + "\n";
            }

            return result;
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
        public void DisplayGrade(string subjectName)
        {
            foreach (Grade grade in grades)
            {
                if (grade.SubjectName == subjectName)
                { 
                    Console.WriteLine(grade.Value);
                }
            }
        }
        public void DeleteGrade(string subjectName, double value, DateTime date) => grades.Remove(new Grade(subjectName, value, date));

        public void DeleteGrade(Grade grade) => grades.Remove(grade);
        public void DeleteGrades()
        {
            grades.Clear();
        }
        public void DeleteGrades(string subjectName)
        {
            grades.RemoveAll(grade => grade.SubjectName == subjectName);
        }
    }
    //public class Grade
    //{
    //    private string _subjectName;
    //    private DateTime? _date;
    //    private double _value;
    //
    //    public string SubjectName
    //    {
    //        get => _subjectName;
    //        set => _subjectName = value;
    //    }
    //    public DateTime Date
    //    {
    //        get => (DateTime)_date;
    //        set => _date = value;
    //    }
    //    public double Value
    //    {
    //        get => _value;
    //        set => _value = value;
    //    }
    //
    //    public Grade()
    //    {
    //        _subjectName = null;
    //        _date = null;
    //        _value = 0;
    //    }
    //    public Grade(string subjectName, double value, DateTime date)
    //    {
    //        _subjectName = subjectName;
    //        _date = date;
    //        _value = value;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Subject Name: {_subjectName}, Date: {_date}" +
    //            $", Value: {_value}";
    //    }
    //    public void Details()
    //    {
    //        Console.WriteLine(this.ToString());
    //    }
    //}

}

