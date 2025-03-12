// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

//Zad1
/*class Person
{
    public string _firstName { get; set; }
    public string _lastName { get; set; }
    public DateTime _dateOfBirth { get; set; }

    public Person (string firstName, string lastName, DateTime dateOfBirth)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }

    public virtual void Details()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}, Date of Birth: {_dateOfBirth.ToShortDateString()}");
    }
    public override string ToString()
    {
        return $"{_firstName} {_lastName}";
    }
}

class Student : Person
{
    public int _year { get; set; }
    public int _group { get; set; }
    public int _indexId { get; set; }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
        : base(firstName, lastName, dateOfBirth)
    {
        _year = year;
        _group = group;
        _indexId = indexId;
    }

    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Year: {_year}, Group: {_group}, Index: {_indexId}");

    }

    public override string ToString()
    {
        return base.ToString() + $"Year: {_year}, Group: {_group}, Index: {_indexId}";
    }

}

class Player : Person
{
    public string _position { get; set;}
    public string _club { get; set; }
    public int _scoredGoals { get; set; }

    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
    : base (firstName, lastName, dateOfBirth)
    {
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    }

    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Position: {_position} , Club: {_club}, Scored Goals: {_scoredGoals}");
    }

    public void ScoreGoal()
    {
        _scoredGoals++;
    }

    public override string ToString()
    {
        return base.ToString() + $"Position: {_position} , Club: {_club}, Scored Goals: {_scoredGoals}";
    }
}

class Program
{
    static void Main()
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

*/

//Zad 2
class Person
{
    public string _firstName { get; set; }
    public string _lastName { get; set; }
    public DateTime _dateOfBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }

    public virtual void Details()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}, Date of Birth: {_dateOfBirth.ToShortDateString()}");
    }
    public override string ToString()
    {
        return $"{_firstName} {_lastName}";
    }
}

class Student : Person
{
    public int _year { get; set; }
    public int _group { get; set; }
    public int _indexId { get; set; }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
        : base(firstName, lastName, dateOfBirth)
    {
        _year = year;
        _group = group;
        _indexId = indexId;
    }

    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Year: {_year}, Group: {_group}, Index: {_indexId}");

    }

    public override string ToString()
    {
        return base.ToString() + $"Year: {_year}, Group: {_group}, Index: {_indexId}";
    }

}

class Player : Person
{
    public string _position { get; set; }
    public string _club { get; set; }
    public int _scoredGoals { get; set; }

    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
    : base(firstName, lastName, dateOfBirth)
    {
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    }

    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Position: {_position} , Club: {_club}, Scored Goals: {_scoredGoals}");
    }

    public void ScoreGoal()
    {
        _scoredGoals++;
    }

    public override string ToString()
    {
        return base.ToString() + $"Position: {_position} , Club: {_club}, Scored Goals: {_scoredGoals}";
    }
}

class Grade : Student
{
    public string _sbujectName { get; set; }
    public DateTime _date {  get; set; }
    public double _value {  get; set; }

    public Grade()


class Program
{
    static void Main()
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