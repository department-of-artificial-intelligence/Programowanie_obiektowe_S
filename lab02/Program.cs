public class Person
{
    protected string _firstName;
    protected string _lastName;
    protected DateTime _dateOfBirth;

    public string Firstname {get; set;}
    public string LastName {get; set;}
    public DateTime DateOfBirth { get; set;}

    Person()
    {
        _firstName = string.Empty;
        _lastName = string.Empty;
        _dateOfBirth = DateTime.MinValue;
    }

    Person(string firstName,
           string lastName,
           DateTime dateOfBirth
          )
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return $"{_firstName}, {_lastName}, {_dateOfBirth}";
    }

    public virtual void Details ()
    {

    }
}

public class Student : Person
{
    private readonly int _year;
    private readonly int _group;
    private readonly int _indexId;

    public int Year {get; set;}
    public int Group {get; set;}
    public int IndexId {get; set;}

    Student() : base()
    {
        _year = 0;
        _group = 0;
        _indexId = 0;
    }

    Student( int year, int group, int indexId ) : base( string firstName, string lastName, DateTime dateOfBirth )
    {
        _year = year;
        _group = group;
        _indexId = indexId;
    }

    public override string ToString()
    {
        return base.ToString() + $", {_year} rok studiow, grupa {_group}, id {_indexId}";
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

    Player() : base()
    {
        Position = string.Empty;
        Club = string.Empty;
        ScoredGoals = 0;
    }

    Player (string position, string club, int scoredGoals) : base( string firstName, string lastName, DateTime dateOfBirth )
    {
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    }

    public override string ToString()
    {
        
    }

   public void ScoreGoal()
    {

    }
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