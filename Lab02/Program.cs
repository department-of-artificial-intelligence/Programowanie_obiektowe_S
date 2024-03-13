// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Hello, World!");

public class Person {
    protected string _firstName;
    protected string _lastName;
    protected DateTime _dateOfBirth;

    public string FirstName { get { return _firstName; } set { _firstName = value; } }
    public string LastName { get { return _lastName; } set { _lastName = value; } }
    public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

    public Person() { } // Konstruktor domyslny
    public Person(string firstName, string lastName, DateTime dateOfBirth) {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    } // Konstruktor parametryczny
    public override string ToString()  {
        return base.ToString();
    } // ToString()
}

public class Player : Person {
    private string _position;
    private string _club;
    private int _scoredGoals;

    public string Position { get { return _position; } set { _club = value; } }
    public string Club { get { return _club; } set { _club = value; } }
    public int ScoredGoals { get {  return _scoredGoals; } set { _scoredGoals = value; } }

    public Player() : base() { } // konstruktor domyslny
    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth) {
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    } // Konstruktor parametryczny
    public override string ToString() {
        return base.ToString() + $", Position: {_position}, Club: {_club}, Scored Goals: {_scoredGoals}";
    } // ToString()
    void ScoreGoal() { 
        _scoredGoals++;
    } // ScoreGoal()
    public virtual void Details() {
        Console.WriteLine("Name: ", _firstName, "Surname: ", _lastName, "");
    }
}


public class Student : Person { 
    private int _year;
    private int _group;
    private int _indexID;

    public int Year { get { return _year; } set { _year = value; } }
    public int Group { get { return _group; } set { _group = value; } }
    public int IndexID { get { return _indexID; } set { _indexID = value; } }

    public Student() : base() { } // Konstruktor domyslny
    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexID) : base(firstName, lastName, dateOfBirth) {
        _year = year;
        _group = group;
        _indexID = indexID;
    } // Konstruktor parametryczny

    public string ToString() { 
        return base.ToString() + $", Year: {_year}, Group: {_group}, Index: {_indexID}"
    } // ToString()
}