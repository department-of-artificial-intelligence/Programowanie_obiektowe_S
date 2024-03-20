// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Person {
    protected string _firstName;
    protected string _lastName;
    protected DateTime _dateOfBirth;

    public string FirstName { get { return _firstName; } set { _firstName = value; } }
    public string LastName { get { return _lastName; } set { _lastName = value; } }
    public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

    public Person() { } // Konstruktor domyslny
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    } // Konstruktor parametryczny
    public override string ToString()
    {
        return base.ToString();
    } // ToString()
}

public class Lecturer : Person {
    protected string _academicTitle;
    protected string _position;

    Lecturer(string firstName, string lastName, DateTime dateOfBirth, string academicTitle, string position) : base(firstName, lastName, dateOfBirth) {
        _academicTitle = academicTitle;
        _position = position;
    }
}

public class Student : Person {
    private static int _id;
    protected int _finalGrade;
    protected int _group;

    protected IList<FinalGrade> _grades;

    public int FinalGrade { get => _finalGrade; set => _finalGrade = value; }
    public int Group { get => _group; set => _group = value; }
    public IList<FinalGrade> Grades { get => _grades; set => _grades = value; }
}