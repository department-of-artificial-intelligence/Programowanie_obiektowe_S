using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LAB2
{ 
    class Program
    {
        class Person
        {
            protected string _firstName;
            protected string _lastName;
            protected DateTime _dateOfBirth;

            public string FirstName { get { return _firstName; } set { _firstName = value; } }
            public string LastName { get => _lastName; set => _lastName = value; }
            public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

            public Person()
            {
                FirstName = string.Empty;
                LastName = string.Empty;
                DateOfBirth = DateTime.MinValue;
            }
            public Person(string FName, string Lname, DateTime DOB)
            {
                FirstName = FName;
                LastName = Lname;
                DateOfBirth = DOB;
            }
            public override string ToString()
            {
                return $"{FirstName}, {LastName}, {DateOfBirth.ToString("dd/M/yy")}";
            }
            public virtual void Details()
            {
                Console.WriteLine(this);
            }
        }
        class Player : Person
        {
            private string _position;
            private string _club;
            private int _scoredGoals;

            public string Position { get => _position; set => _position = value; }
            public string Club { get => _club; set => _club = value; }
            public int ScoredGoals { get => _scoredGoals; set => _scoredGoals = value; }

            public Player() : base()
            {
                Position = string.Empty;
                Club = string.Empty;
                ScoredGoals = 0;
            }
            public Player(string FName, string LName, DateTime DOB, string position, string club, int scoredGoals) : base(FName, LName, DOB)
            {
                Position = position;
                Club = club;
                ScoredGoals = scoredGoals;
            }
            public override string ToString()
            {
                return $"Person : {base.ToString()} ON Position: {Position}, Club: {Club}, Scored goals: {ScoredGoals}";
            }
            public override void Details()
            {
                Console.WriteLine(this);
            }
            public void ScoreGoal()
            {
                ScoredGoals++;
            }
        }
        class Grade
        {
            private string _subjectName;
            private DateTime _date;
            private double _value;

            public string SubjectName { get => _subjectName; set => _subjectName = value; }
            public DateTime Date { get => _date; set => _date = value; }
            public double Value { get => _value; set => _value = value; }
            public Grade()
            {
                _subjectName = string.Empty;
                _date = DateTime.MinValue;
                _value = 0;
            }
            public Grade(string subjectName, DateTime date, double value)
            {
                SubjectName = subjectName;
                Date = date;
                Value = value;
            }
            public override string ToString()
            {
                return $"{SubjectName}, {Date}, {Value}";
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
            private int _indexID;
            private List<Grade> _grades;

            public int Year { get => _year; set => _year = value; }
            public int Group { get => _group; set => _group = value; }
            public int IndexID { get => _indexID; set => _indexID = value; }
            public List<Grade> Grades { get { return _grades; } }
            public Student() : base()
            {
                Year = 0;
                Group = 0;
                IndexID = 0;
            }
            public Student(string FName, string LName, DateTime DOB, int yr, int grp, int ID) : base(FName, LName, DOB)
            {
                Year = yr;
                Group = grp;
                IndexID = ID;
            }
            public override string ToString()
            {
                return $"Person : {base.ToString()} ON Year: {Year}, Group: {Group}, Index ID: {IndexID}";
            }
            public override void Details()
            {
                Console.WriteLine(this);
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
        }
    }
}