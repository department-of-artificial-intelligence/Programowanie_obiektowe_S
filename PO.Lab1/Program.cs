using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    protected string _firstName;
    protected string _lastName;
    protected DateTime _dateOfBirth;
    public string FirstName { get { return _firstName; } set { _firstName = value; }}
    public string LastName { get { return _lastName; } set { _lastName = value; } }
    public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
    public Person()
    {
        _firstName = "Default";
        _lastName = "Default";
        _dateOfBirth = default;
    }
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
    public override string ToString()
    {
        return $"First name: {_firstName} | Last name: {_lastName} | Birthday: {_dateOfBirth}";
    }
    public virtual void Details()
    {
        Console.WriteLine(this.ToString());
    }
}

public class Grade
{
    private string _subjectName;
    private DateTime _date;
    private double _value;

    public string SubjectName { get { return _subjectName; } set { _subjectName = value; } }
    public DateTime Date { get { return _date; } set {  _date = value; } }
    public double Value { get { return _value; } set { _value = value; } }
    
    public Grade()
    {
        _subjectName = "Default";
        _date = default;
        _value = 0;
    }
    public Grade(string subjectName, double value, DateTime date)
    {
        SubjectName = subjectName;
        Date = date;
        Value = value;
    }
    public override string ToString()
    {
        return $"Subject: {_subjectName} | Date: {_date} | Grade: {_value} ";
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
    private int _indexID;
    private List<Grade> _grades;
    public List<Grade> Grades {  get { return _grades; } }
    public int Year { get { return _year; } set { _year = value; } }
    public int Group { get { return _group; } set { _group = value; } }
    public int IndexID { get { return _indexID; } set { _indexID = value; } }
    
    public Student():base() {
        _year = 0;
        _group = 0;
        _indexID = 0;
    }
    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexID):base(firstName, lastName, dateOfBirth)
    {
        Year = year;
        Group = group;
        IndexID = indexID;
    }
    public override string ToString()
    {
        return base.ToString() + $" | Year: {_year} | Group: {_group} | Index: {_indexID}\n";
    }
    public void AddGrade(string subject, double value, DateTime date)
    {
        Grade grade = new Grade(subject,value,date);
        _grades.Add(grade);
    }
    public void AddGrade(Grade grade)
    {
        _grades.Add(grade);
    }
    public void DisplayGrades()
    {
        foreach (var grade in _grades)
        {
            Console.WriteLine(grade);
            Console.WriteLine("\n");
        }
    } 
    public void DeleteGrade(Grade grade)
    {
        if(_grades.Contains(grade))
        _grades.Remove(grade);
    }
    public void DeleteGrade(string subject, double value, DateTime date)
    {
        Grade t = new Grade(subject,value, date);
        if(_grades.Contains(t))
            _grades.Remove(t);
    }
    public void DeleteGrades()
    {
        _grades.Clear();
    }
    public void DeleteGrades(string subject)
    {
        var gr = _grades.Where(g => g.SubjectName == subject);
        foreach (var grade in gr)
        {
            _grades.Remove(grade);
        }
    }
}

public class Player : Person
{
    private string _position;
    private string _club;
    private int _scoredGoals;

    public string Position { get { return _position; } set { _position = value; } }
    public string Club { get { return _club; } set { _club = value; } }
    public int ScoredGoals { get {  return _scoredGoals; } set { _scoredGoals = value; } }

    public Player():base() {
        _position = "Default";
        _club = "Default";
        _scoredGoals = 0;
    }
    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals):base(firstName,lastName,dateOfBirth)
    {
        Position = position;
        Club = club;
        ScoredGoals = scoredGoals;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Position: {_position} | Club: {_club} | Goals: {_scoredGoals}\n";
    }

    public void ScoreGoal()
    {
        _scoredGoals++;
    }

}
namespace PO.Lab1
{
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

            Console.WriteLine("Zad 2  =====================\n");
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
        }
    }
}
