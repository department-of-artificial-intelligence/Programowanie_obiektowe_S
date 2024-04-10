using System;
using System.Collections.Generic;

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
        return $"Name:{_firstName} {_lastName} \nDate of Birth:{_dateOfBirth}";
    }

    public virtual void Details()
    {
        System.Console.WriteLine(this.ToString());
    }
}

public class Student : Person
{
    private int _year;
    private int _group;
    private int _indexId;
    private IList<Grade> __grades;

    public int Year { get; set; }
    public int Group { get; set; }
    public int IndexId { get; set; }
    public IList<Grade> Grades { get; set; }
    public Student()
    {
        _year = 0;
        _group = 0;
        _indexId = 0;
    }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
        : base(firstName, lastName, dateOfBirth)
    {
        _year = year;
        _group = group;
        _indexId = indexId;
        Grades = new List<Grade>();
    }
    public override string ToString()
    {
        string result = $"{base.ToString()}\nYear: {_year}\nGroup: {_group}\nIndex ID: {_indexId}\nGrades:\n";

        foreach (Grade grade in Grades)
        {
            result += grade.ToString() + "\n";
        }

        return result;
    }

    public void AddGrade(string subjectName, double value, DateTime date)
    {
        Grade newGrade = new Grade(subjectName, value, date);
        Grades.Add(newGrade);
    }

    public void AddGrade(Grade grade)
    {
        Grades.Add(grade);
    }

    public void DisplayGrades()
    {
        foreach (Grade grade in Grades)
        {
            grade.ToString();
        }
    }

    public void DisplayGrades(string subjectName)
    {
        foreach (Grade grade in Grades)
        {
            if (grade.SubjectName == subjectName)
            {
                grade.ToString();
            }
        }
    }

    public void DeleteGrade(string subjectName, double value, DateTime date)
    {
        Grade rmGrade = new Grade(subjectName, value, date);
        Grades.Remove(rmGrade);
    }

    public void DeleteGrade(Grade grade)
    {
        Grades.Remove(grade);
    }

    public void DeleteGrades(string subjectName)
    {
        foreach (Grade grade in Grades)
        { if (grade.SubjectName == subjectName) { Grades.Remove(grade); } }
    }

    public void DeleteGrades()
    {
        Grades.Clear();
    }

}

public class Grade
{
    private string _subjectname;
    private DateTime _date;
    private double _value;

    public string SubjectName { get; set; }
    public DateTime Date { get; set; }
    public double Value { get; set; }

    public Grade()
    {
        _subjectname = string.Empty;
        _date = DateTime.MinValue;
        _value = 0;
    }

    public Grade(string subjectName, double value, DateTime date)
    {
        _subjectname = subjectName;
        _date = date;
        _value = value;
    }

    public override string ToString()
    {
        return $"Subject: {_subjectname}, Value: {_value}, Date: {_date}";
    }

    public void Details()
    {
        Console.WriteLine(ToString());
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

    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base (firstName, lastName, dateOfBirth)
    {
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Pozycja:{_position} Klub:{_club} Gole:{_scoredGoals}";
    }

    public virtual void ScoreGoal()
    {
        _scoredGoals++;
    }
}

public class HandballPlayer : Player
{
    public HandballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals = 0)
        : base(firstName,lastName,dateOfBirth,position,club,scoredGoals){}

    public override void ScoreGoal()
    {
        base.ScoreGoal();
        Console.WriteLine("Handball player scored goal!");
    }
}

public class FootballPlayer : Player
{
    public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals = 0)
        : base(firstName, lastName, dateOfBirth, position, club, scoredGoals) {}

    public override void ScoreGoal()
    {
        base.ScoreGoal();
        Console.WriteLine("Football player scored goal!");
    }
}

public class Program
{
    public static void Main()
    {
        Person footballPlayer =
        new FootballPlayer("Mateusz", "Żbik", new DateTime(1986, 8, 10), "striker", "FC Barcelona", 10);
        Person handballPlayer =
        new HandballPlayer("Piotr", "Kos", new DateTime(1984, 9, 14), "striker", "FC Bayern");
        footballPlayer.Details();
        handballPlayer.Details();
        ((Player)handballPlayer).ScoreGoal(); // rzutowanie bezpośrednie
        (footballPlayer as Player).ScoreGoal(); // rzutowanie referencyjne
        footballPlayer.Details();
        handballPlayer.Details();
    }
}