



using System;

class Person {
    protected string _firstname;
    protected string _lastname;
    protected DateTime _dayeOfBirth;

    public Person()
    {
        _firstname = "none";
        _lastname = "none";
        _dayeOfBirth = DateTime.MinValue;
    }
    public Person(string firstname, string lastname, DateTime dayeOfBirth)
    {
        _firstname = firstname;
        _lastname = lastname;
        _dayeOfBirth = dayeOfBirth;
    }
    public string FirstName
    {
        get { return _firstname; }
        set { _firstname = value; }
    }
    public string LastName
    {
        get { return _lastname; }
        set { _lastname = value; }
    }
    public  DateTime DateOfBirth
    {
        get { return (DateTime)_dayeOfBirth; }
        set { _dayeOfBirth = value;}

    }
    public override string ToString()
    {
        return $"FirstName: {_firstname}, LastName: {_lastname}, DateOfBirth: {_dayeOfBirth}";
    }
    public virtual void Details()
    {
        Console.WriteLine(this);
    }
} 
class Player: Person 
{
    private string _position;
    private string _club;
    private int _scoredGoals= 0;

    public Player()
    {
        _position = "none";
        _club = "none";
        _scoredGoals = 0;
    }
    public Player(string firstname, string lastname, DateTime dateOfBirth, string position, string club, int scoredGoals):base(firstname, lastname, dateOfBirth)
    {
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    }
    public string Position
    {
        get { return _position; }
        set { _position = value; }
    }
    public string Club
    {
        get { return _club; }
        set { _club = value; }
    }
    public int ScoredGoals
    {
        get { return _scoredGoals;}
        set { _scoredGoals = value;}
    }
    public override string ToString()
    {
        return $"Position: {_position}, Club: {_club}, ScoredGoals: {_scoredGoals}";
    }
    public void ScoreGoal()
    {
        _scoredGoals++;
    }

}
class Student: Person
{
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
    public int IndexId
    {
        get { return _indexId; }
        set { _indexId = value; }
    }
    public Student()
    {
        _year = 0;
        _group = 0;
        _indexId = 0;
    }
    public Student(string firstname, string lastname, DateTime dateofBirth , int year, int group, int indexId): base(firstname, lastname, dateofBirth)
    {
        Year = year;
        Group = group;
        IndexId = indexId;
        Year = year;
        Group = group;
        IndexId = indexId;
    }
    public override string ToString()
    {
        return $"Year: {_year}, Group: {_group}, Index: {_indexId}";
    }
}
class Grade : Student {
    private string _subjectName;
    private DateTime _date;
    private double _value;
}


public class Program
{
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



