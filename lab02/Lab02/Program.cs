using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class Person {
    private string _firstName;
    private string _lastName;
    private DateTime _dateOfBirth;

    public string FirstName {
        get { return _firstName; }
        set {  _firstName = value; }
    }
    public string LastName { 
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
        _firstName = "Default";
        _lastName = "Default";
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

    public virtual void Details()
    {
        Console.WriteLine(this);
    }
}

public class Student : Person
{
    private int _year;
    private int _group;
    private int _indexId;
    private IList<Grade> _grades;

    public int year
    {
        get { return _year; }
        set { _year = value; }
    }
    public int group
    {
        get { return _group; }
        set { _group = value; }
    }
    public int indexId
    {
        get { return _indexId; }
        set { _indexId = value; }
    }

    public IList<Grade> Grades
    {
        get { return _grades; }
    }

    public Student() : base()
    {
        _year = 0;
        _group = 0;
        _indexId = 0;
        _grades = new List<Grade>();
    }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
    {
        _year = year;
        _group = group;
        _indexId = indexId;
        _grades = new List<Grade>();
    }

    public void AddGrade(string subjectName, double value, DateTime date)
    {
        _grades.Add(new Grade(subjectName, value, date));
    }

    public void AddGrade(Grade grade)
    {
        _grades.Add(grade);
    }

    public void DisplayGrades()
    {
        foreach (Grade item in _grades)
        {
            item.Details();
        }
    }

    public void DisplayGrades(string subjectName)
    {
        foreach (Grade item in _grades)
        {
            if (item.SubjectName == subjectName)
            {
                item.Details();
            }
        }
    }

    public void DeleteGrade(string subjectName, double value, DateTime date)
    {
        for (int i = 0; i < _grades.Count; ++i)
        {
            if (_grades[i].IsSame(subjectName, value, date))
            {
                _grades.RemoveAt(i);
            }
        }
    }

    public void DeleteGrade(Grade grade)
    {
        for (int i = 0; i < _grades.Count; ++i)
        {
            if (_grades[i] == grade)
            {
                _grades.RemoveAt(i);
            }
        }
    }

    public void DeleteGrades(string subjectName)
    {
        for (int i = 0; i < _grades.Count; ++i)
        {
            if (_grades[i].SubjectName == subjectName)
            {
                _grades.RemoveAt(i);
            }
        }
    }

    public void DeleteGrades()
    {
        _grades.Clear();
    }
    public override string ToString()
    {
        string s = new string(base.ToString() + $", Year: {_year}, Group: {_group}, ID: {_indexId} \n Oceny: \n");
        foreach (Grade item in _grades)
        {
            s += item.ToString() + '\n';
        }
        return s;
    }

}

public class Grade
{
    private string _subjectName;
    private DateTime _date;
    private double _value;

    public bool IsSame(string subjectName, double value, DateTime date)
    {
        return subjectName == _subjectName && date == _date && value == _value;
    }
    public string SubjectName
    {
        get { return _subjectName; }
        set { _subjectName = value; }
    }
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public double Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public Grade()
    {
        _subjectName = "Brak";
        _date = DateTime.MinValue;
        _value = 0;
    }

    public Grade(string subjectName, double value, DateTime date)
    {
        _date = date;
        _subjectName = subjectName;
        _value = value;
    }

    public override string ToString()
    {
        return $"Subject Name: {_subjectName}, Date: {_date}, Value: {_value}";
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

    public string Position
    {
        get { return _position; }
        set { _position = value; }
    }
    public string Club
    {
        get { return _club;}
        set { _club = value; }
    }
    public int ScoredGoals
    {
        get { return _scoredGoals;}
        set { _scoredGoals = value;}
    }

    public Player() : base()
    {
        _position = "Brak";
        _club = "Brak";
        _scoredGoals = 0;
    }

    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
    {
        _scoredGoals=scoredGoals;
        _position = position;
        _club = club;
    }

    public override string ToString()
    {
        return base.ToString() + $", Position: {_position}, Club: {_position}, Scored Goals: {_scoredGoals}";
    }

    public virtual void ScoreGoal()
    {
        ++_scoredGoals;
    }
}

public class FootballPlayer : Player
{
    public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals = 0) : base(firstName, lastName, dateOfBirth, position, club, scoredGoals) { }
    public override void ScoreGoal()
    {
        base.ScoreGoal();
        Console.WriteLine("Football player scored goal");
    }
}

public class HandballPlayer : Player
{
    public HandballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals = 0) : base(firstName, lastName, dateOfBirth, position, club, scoredGoals) { }
    public override void ScoreGoal()
    {
        base.ScoreGoal();
        Console.WriteLine("Handball player scored goal!");
    }
}

internal class Program
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
        Person footballPlayer = new FootballPlayer("Mateusz", "Żbik", new DateTime(1986, 8, 10), "striker", "FC Barcelona", 10);
        Person handballPlayer = new HandballPlayer("Piotr", "Kos", new DateTime(1984, 9, 14), "striker", "FC Bayern");
        footballPlayer.Details();
        handballPlayer.Details();
        ((Player)handballPlayer).ScoreGoal(); // rzutowanie bezpośrednie
        (footballPlayer as Player).ScoreGoal(); // rzutowanie referencyjne
        footballPlayer.Details();
        handballPlayer.Details();

    }
}
