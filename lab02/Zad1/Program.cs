using System;

public class Person
{
    protected string _firstName;
    protected string _lastName;
    protected DateTime _dateOfBirth;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person()
    {
        _firstName = string.Empty;
        _lastName = string.Empty;
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
        return base.ToString();
    }

    public virtual void Details()
    {
        System.Console.WriteLine(ToString());
    }
}

public class Student : Person
{
    private int _year;
    private int _group;
    private int _indexId;

    public int Year { get; set; }
    public int Group { get; set; }
    public int IndexId { get; set; }

    public Student()
    {
        _year = 0;
        _group = 0;
        _indexId = 0;
    }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
        _year = year;
        _group = group;
        _indexId = indexId;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}

public class Player : Person
{
    private string _position;
    private string _club;
    private int _scoredGoals;

    public string Position { get; set; }
    public string Club { get; set; }
    public int ScoredGoals { get; set; }

    public Player()
    {
        _position = string.Empty;
        _club = string.Empty;
        _scoredGoals = 0;
    }

    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
    {
        _firstName=firstName;
        _lastName=lastName;
        _dateOfBirth=dateOfBirth;
        _position = position;
        _club = club;
        _scoredGoals=scoredGoals;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Pozycja:{_position} Klub:{_club} Gole:{_scoredGoals}";
    }

    public void ScoreGoal()
    {
        _scoredGoals++;
    }
}

public class Program
{
    public static void Main()
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