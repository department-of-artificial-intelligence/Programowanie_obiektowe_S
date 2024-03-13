using System;
public class Person
{
    protected string _firstName;
    protected string _lastName;
    protected DateTime _dateOfBirth;

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
        return $"Imie:{_firstName}\n Nazwisko: {_lastName}/n Data urodzenia: {_dateOfBirth}";
    }

    public virtual void Detalis()
    {
        base.ToString();
    }
}
public class Player : Person
{
    private string _position;
    private string _club;
    public int _scoredGoals;

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
        set { _scoredGoals = value; }
    }
    public Player() 
    {  
        _position = string.Empty;
        _club = string.Empty;
        _scoredGoals = 0;
    }
    public Player(string firstName, string lastName , DateTime dateOfBirth , string position , string club , int scoredGoals)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    }
    public override string ToString()
    {
        return $"Imie: {_firstName}\n Nazwisko: {_lastName}\n Data urodzenia: {_dateOfBirth}\n,Pozycja: {_position}, Club: {_club}\n , Strzelone gole:{_scoredGoals} ";
    }
    public void ScoreGoal()
    {
        _scoredGoals++;
    }


}

public class Student :  Person
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
    public Student(string firstName, string lastName, DateTime dateOfBirth , int year, int group, int indexId)
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
        return $"Imie: {_firstName}\n Nazwisko: {_lastName}\n Data urodzenia: {_dateOfBirth}\n,Rok: {_year}, Grupa: {_group}\n , index:{_indexId} ";

    }
}