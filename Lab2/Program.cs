using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Person
{
    public string _firstName;
    public string _lastName;
    public DateTime _dateOfBirth;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set { _dateOfBirth = value; }
    }

    public Person()
    {
        _firstName = "none";
        _lastName = "none";
        _dateOfBirth = DateTime.MinValue;
    }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return $"First Name: {_firstName}, Last Name: {_lastName}, Date of Birth: {_dateOfBirth}";
    }

    virtual public void Details()
    {
        Console.WriteLine(this.ToString().Replace(',', '\n'));
    }
}

public class Student : Person
{
    private int _year;
    private int _group;
    private int _indexId;

    public int Year { get { return _year; } set {  _year = value; } }

    public int Group { get { return _group; } set { _group = value; } }

    public int IndexId { get { return _indexId;} set { _indexId = value; } }

    public Student()
    {
        _year = 0;
        _group = 0;
        _indexId = 0;
    }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
    {
        _year = year;
        _group = group;
        _indexId = indexId;
    }

    public override string ToString()
    {
        return $"First Name: {_firstName}, Last Name: {_lastName}, Date of Birth: {_dateOfBirth}, Year: {_year}, Group: {_group}, IndexId: {_indexId}";
    }
}

public class Player : Person 
{
    private string _position;
    private string _club;
    private int _scoredGoals;
    public string Position { get { return _position; } set { _position = value; } }

    public string Club { get { return _club;} set { _club = value; } }

    public int ScoredGoals { get { return _scoredGoals; } set { _scoredGoals = value; } }
        
    public Player()
    {
        _position = "none";
        _club = "none";
        _scoredGoals = 0;
    }

    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
    {
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    }

    public override string ToString()
    {
        return $"First Name: {_firstName}, Last Name: {_lastName}, Date of Birth: {_dateOfBirth}, Position: {_position}, Cub: {_club}, Scored Goals: {_scoredGoals}";
    }


}

public class Grade : Student
{
    private string _subjectName;
    private DateTime _date;
    private double _value;

    public string SubjectName { get { return _subjectName;} set { _subjectName = value; } }

    public DateTime Date { get { return _date;} set { _date = value;} }

    public double Value { get { return _value;} set { _value = value;} }

    public Grade()
    {
        _subjectName = "none";
        _date = DateTime.MinValue;
        _value = 0;
    }

    public Grade(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId, string subjectName, DateTime date, double value) : base(firstName, lastName, dateOfBirth, year, group, indexId)
    {

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
        person3.Details();
    }
}
