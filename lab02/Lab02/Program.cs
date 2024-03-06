using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

public class Person { 
    private String _firstName;
    private String _lastName;
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
        return $"{_firstName} {_lastName} data ur. {_dateOfBirth}";
    }

    public virtual void Details()
    {
        Console.WriteLine(ToString());
    }
}

public class Student : Person
{
    private int _year;
    private int _group;
    private int _indexId;

    public int year 
    { 
        get { return _year; }
        set {  _year = value; } 
    }
    public int group
    { 
        get { return _group;}
        set { _group = value; }
    }
    public int indexId 
    {
        get { return _indexId; }
        set { _indexId = value; }
    }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
    {
        _year = year;
        _group = group;
        _indexId = indexId;
    }

    public Student()
    {
        _year = 0;
        _group = 0;
        _indexId = 0;
    }

    public override string ToString()
    {
        return base.ToString() + $", {_year} rok studiow, grupa {_group}, id {_indexId}" ;
    }
}

public class Player : Person
{
    public Player(string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
    {
    }
}