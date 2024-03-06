using System;

class Person
{
    protected string _firstName;
    protected string _lastName;
    protected DateTime _dateOfBirth;

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public Person()
    {
        FirstName = "";
        LastName = "";
        DateOfBirth = DateTime.MinValue;
    }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public virtual void Details()
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return $"Person: {FirstName} {LastName} {DateOfBirth}";
    }
}

class Student
{
    private int _year;
    private int _group;
    private int _indexId;

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public int Group
    {
        get => _group;
        set => _group = value;
    }

    public int IndexId
    {
        get => _indexId;
        set => _indexId = value;
    }

    public Student()
    {
        Year = 0;
        Group = 0;
        IndexId = 0;
    }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
    {
        Year = year;
        Group = group;
        IndexId = indexId;
    }

    public void Details()
    {
        var message = $"Student: {base.ToString()}";
        Console.WriteLine(message);
    }
}

class Player {

    private string _position;
    private string _club;
    private int _scoreGoals;

    public string Position {

        get => _position;
        set => _position = value;

    }

    public string Club {

        get => _club;
        set => _club = value;

    }

    public int ScoredGoals {

        get => _scoreGoals;
        set => _scoreGoals = value;


    }


    Player(){

        Position = "";
        Club = "";
        ScoredGoals = 0;


}

    Player(string firstName, string lastName, DateTime dateOfBirth, string Position, string Club, int scoreGoals) {

        Position = _position;
        Club = _club;
        ScoredGoals = _scoreGoals;
    
    }




}





class Program
{
    static void Main()
    {
        var jaredPadalecki = new Person("Jared", "Padalecki", DateTime.Now);
        Console.WriteLine(jaredPadalecki);
    }
}