// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.DataAnnotations;
namespace Lab2.App
{
   public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName;} set { _lastName = value;} }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public Person()
        {
            _firstName = "First Name";
            _lastName = "Last Name";
            _dateOfBirth = DateTime.Now;
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            string otwet = $"First Name: {FirstName} Last Name: {LastName} DateOfBirth: {DateOfBirth} ";
            return otwet;
        }
        public virtual void Details ()
        {
            Console.WriteLine(this);
        }
    }
    public class Student : Person
    {
        private int _year;
        private int _groupe;
        private int _indexId;
        List<Grade> _grades=new List<Grade>();
        public int Year { get { return _year; } set { _year = value; } }
        public int Groupe { get { return _groupe; } set { _groupe = value; } }
        public int IndexId { get { return _indexId;} set { _indexId = value; } }
        public IList<Grade> Grades { get { return _grades; } }
        public Student()
        {
            _year = 0;
            _groupe = 0;   
            _indexId = 0;
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int groupe, int indexId) : base(firstName, lastName, dateOfBirth)
        {
            Year = year;
            Groupe = groupe;
            IndexId = indexId;
        }
        public override string ToString()
        {
            string otwet =base.ToString();
            otwet+=$"Year: {Year} Groupe: {Groupe} IndexId: {IndexId} ";
            return otwet;
        }
        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade grades=new Grade(subjectName,date,value);
            _grades.Add(grades);
        }
        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }
    }
    public class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;
        public string SubjectName { get { return _subjectName; } set { _subjectName = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public double Value { get { return _value; } set { _value = value; } }
        public Grade()
        {
            _subjectName = "none";
            _date = DateTime.Now;
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
            return $"SubjectName: {SubjectName} Date: {Date} Value: {Value} ";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
    public class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;
        public string Position { get { return _position; } set { _position = value; } }
        public string Club { get { return _club; } set { _club = value; } }
        public int ScoredGoals { get { return _scoredGoals; } set { _scoredGoals = value; } }
        public Player() 
        {
            _position = "none";
            _club = "none";
            _scoredGoals = 0;
        }
        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Club = club;
            ScoredGoals = scoredGoals;
        }
        public override string ToString()
        {
            string otwet= base.ToString();
            otwet += $"Position: {Position} Club: {Club} ScoredGoals: {ScoredGoals} ";
            return otwet;
        }
        public void ScoreGoal ()
        { 
            ScoredGoals++;
        }
    }
    class Program
    {
        static void Main(string[] args)
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