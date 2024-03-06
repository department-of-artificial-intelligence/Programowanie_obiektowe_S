using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace PO.Lab2;
class Program
{
    class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _birthDate;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } }
        public Person()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthDate = DateTime.MinValue;
        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            _birthDate = birthDate;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {BirthDate.ToString("dd/M/yy")}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
    class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;
        public string SubjectName { get { return _subjectName; } set { _subjectName = value; } }
        public DateTime Date { get => _date; set => _date = value; }
        public double Value { get => _value; set => _value = value; }
        public Grade()
        {
            _subjectName = string.Empty;
            _date = DateTime.MinValue;
            _value = 0;
        }
        public Grade(string subjectName, double value, DateTime date)
        {
            _subjectName = subjectName;
            _date = date;
            _value = value;
        }
        public override string ToString()
        {
            return $"{SubjectName} {Date} {Value}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
    class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;
        private List<Grade> _grades;
        public int Year { get { return _year; } set { _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int IndexId { get { return _indexId; } set { _indexId = value; } }
        public List<Grade> Grades { get { return _grades; } }
        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();
        }
        public Student(string firstName, string lastName, DateTime birthDate, int year, int group, int indexId) : base(firstName, lastName, birthDate)
        {
            Year = year;
            Group = group;
            IndexId = indexId;
            _grades= new List<Grade>();
        }
        public override string ToString()
        {
            string res = $"{base.ToString()}|Student info: {Year} {Group} {IndexId} \n\tGrades:";
            if (_grades != null)
                foreach (var item in _grades)
                    res += "\n\t\t" + item;
            return res;
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
            foreach (var g in _grades)
                Console.WriteLine(g);
        }
        public void DisplayGrades(string subjectName)
        {
            foreach (var g in _grades)
                Console.WriteLine(g.SubjectName == subjectName ? g : "");
        }
        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.Remove(_grades.First(g => g.SubjectName == subjectName && g.Value == value && g.Date == date));
        }
        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }
        public void DeleteGrades()
        {
            _grades.Clear();
        }
        public void DeleteGrades(string subjectName)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName);
        }
    }
    class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public string Position { get { return _position; } set { _position = value; } }
        public string Club { get { return _club; } set { _club = value; } }
        public int ScoredGoals { get { return _scoredGoals; } set { _scoredGoals = value; } }
        public Player() : base()
        {
            _position = string.Empty;
            _club = string.Empty;
            _scoredGoals = 0;
        }
        public Player(string firstName, string lastName, DateTime birthDate, string position, string club, int scoredGoals) : base(firstName, lastName, birthDate)
        {
            Position = position;
            Club = club;
            ScoredGoals = scoredGoals;
        }
        public override string ToString()
        {
            return $"{base.ToString()}|Player info : {Position} {Club} {ScoredGoals}";
        }
        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
    public static void Main(string[] args)
    {
        Person person1 = new Person("Adam", "Miś", new DateTime(1990, 3, 20, 12, 30, 10));
        Person person2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 3, 5, 12345);
        Person person3 = new Player("Robert", "Lewandowski", new DateTime(1988, 10, 3), "Striker", "Bayern", 41);
        person1.Details();
        person2.Details();
        person3.Details();
        Student student = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 29), 2, 5, 54321);
        student.Details();
        ((Player)person3).ScoreGoal();
        person3.Details();
        //
        ((Student)person2).AddGrade("PO", 5.0D, new DateTime(2011, 2, 20));
        ((Student)person2).AddGrade("Bazy Danych", 5.0D, new DateTime(2011, 2, 13));
        person2.Details();
        Grade grade = new Grade("Bazy Danych", 5.0D, new DateTime(2011, 5, 1));
        student.AddGrade(grade);
        student.AddGrade("AWWW", 5.0D, new DateTime(2011, 5, 11));
        student.AddGrade("AWWW", 4.5D, new DateTime(2011, 4, 2));
        student.Details();
        student.DeleteGrade("AWWW", 4.5D, new DateTime(2011, 4, 2));
        student.Details();
        student.DeleteGrades("AWWW");
        student.Details();
        student.AddGrade("AWWW", 5.0D, new DateTime(2011, 4, 3));
        student.DeleteGrades();
        student.Details();
    }
}