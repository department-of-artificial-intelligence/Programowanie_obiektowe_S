﻿using Lab2.App;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

namespace Lab2.App
{
    class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirh;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirh; } set { _dateOfBirh = value; } }

        public Person()
        {
            _firstName = "Nieznany";
            _lastName = "NIezanany";
            _dateOfBirh = DateTime.MinValue;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirh = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Persona | Name: {_firstName}, LastName: {_lastName}, DateOfBirth:{_dateOfBirh}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }


    }

    class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;


        public int Year { get { return _year; } set { _year = value; } }

        public int Group { get { return _group; } set { _group = value; } }

        public int IndexId { get { return _indexId;} set { _indexId = value; } }

        public Student() { 
            _year = 0;
            _group = 0;
            _indexId = 0;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId): base(firstName, lastName, dateOfBirth) 
        {
            _year = year;
            _group = group;
            _indexId = indexId;

        }

        public override string ToString() {
            return $"Student | Name:{_firstName}, LastName: {_lastName}, Year: {_year}, Group:{_group}, IndexId:{_indexId}";
        }


    }

     class Player: Person
    {
        private string _position;
        private string _club;
        private int _scoreGoles = 1;

        public string Position { get { return _position; } set { _position = value; } }

        public string Club { get { return _club; } set { _club = value; } }
        public int ScoreGoles { get {  return _scoreGoles; } set {_scoreGoles = value; } }

        public Player()
        {
            _position = "Nieznana";
            _club = "Nieznany";
            _scoreGoles = 1;
        }

        public Player(string firstName,string lastName,DateTime dateOfBirth, string position,  string club, int scoreGoles) : base(firstName,lastName, dateOfBirth) 
        {
            _position = position;
            _club = club;
            _scoreGoles = scoreGoles;
           
        }

        public override string ToString()
        {
            return $"Student | Name:{_firstName}, LastName: {_lastName}, Position:{_position}, Club:{_club}";
        }

        public void ScoreGoal()
        {
            _scoreGoles++;
        }
    }

    class Grade
    {
        private string _subjectName;
        private DateTime _date;
        private double _value;

        public string SubjectName { get { return _subjectName; } set { _subjectName = value; } }

        public DateTime Date { get { return _date; } set { _date = value; } }

        public double Value { get { return _value; } set { _value = value; } }

        public Grade()
        {
            _subjectName = "Nieznany";
            _date = DateTime.MinValue;
            _value = 0;
        }

        public Grade(string subjectName, DateTime date, double value) 
        {
            _subjectName=subjectName;
            _date = date;   
            _value = value;
        }

        public override string ToString()
        {
            return $"Grade | SubjectName:{_subjectName}, Date: {_date}, Value:{_value}";
        }

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
        ((Player) person3).ScoreGoal();
        person3.Details();

    }
}
