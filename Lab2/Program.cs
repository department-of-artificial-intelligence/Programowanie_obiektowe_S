using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

class Person
{
    protected string _firstName;

    protected string _lastName;

    protected DateTime _dateOfBirth;

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Person () { }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;

    }

    public virtual string ToString()
    {
        return $"{FirstName} {LastName}, Born: {DateOfBirth.ToShortDateString()}";
    }

    public virtual void Details()
    {
        Console.WriteLine(ToString());
    }

}
class Student : Person
{
    private int _year;

    private int _group;

    private int _indexId;

    public int Year { get; set; }

    public int Group { get; set; }

    public int IndexId { get; set; }


    public Student() { }
    
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
            :base(firstName, lastName, dateOfBirth){
            Year = year;
            Group = group;
            IndexId = indexId;
        }
        public override string ToString()
    {
        return base.ToString() + $"Year : {Year}, Group {Group}, Index ID: {IndexId}";
    }

    public override void Details()
    {
        Console.WriteLine(ToString());
    }
}

class Player : Person
{
    private string _position;

    private string _club;

    private int _scoredGoals;

    public string Position { get; set; }

    public string Club { get; set; }

    public int ScoredGoals { get; set; }


    public Player() { }

    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
        : base(firstName, lastName, dateOfBirth)
    {
        Position = position;
        Club = club;
        ScoredGoals = scoredGoals;
    }

    public override string ToString()
    {
        return base.ToString() + $", Position: {Position}, Club: {Club}, Goals{ScoredGoals}";
    }


        public override void Details()
    {
        Console.WriteLine(ToString());
    }
    public void ScoreGoals()
    {
        ScoreGoals++;
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






