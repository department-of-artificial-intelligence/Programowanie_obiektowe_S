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
    
    public void  AddGrade(string subjectName, double value, DateTime date)
    {
        Grade newGrade = new Grade(subjectName,value,date);
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
        foreach(Grade grade in Grades)
        {
            if (grade.SubjectName == subjectName)
            {
                grade.ToString();
            }
        }
    }

    public void DeleteGrade(string subjectName, double value, DateTime date)
    {
        Grade rmGrade = new Grade(subjectName,value,date);
        Grades.Remove(rmGrade);
    }

    public void DeleteGrade(Grade grade)
    {
        Grades.Remove(grade);
    }

    public void DeleteGrades(string subjectName)
    {
        foreach (Grade grade in Grades)
        { if (grade.SubjectName == subjectName) {  Grades.Remove(grade); } }
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

    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
        : base(firstName, lastName, dateOfBirth)
    {
        _position = position;
        _club = club;
        _scoredGoals = scoredGoals;
    }

    public override string ToString()
    {
        return $"{base.ToString()}{_position}{_club}{_scoredGoals}";
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