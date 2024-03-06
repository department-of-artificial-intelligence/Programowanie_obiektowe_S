
public class Person {
    protected string _firstName = "";
    protected string _lastName = "";
    protected DateTime _dateOfBirth;

    public string FirstName { get { return _firstName; } set { _firstName = value; } }
    public string LastName { get { return _lastName; } set { _lastName = value; } } 
    public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
    
    public Person() { _dateOfBirth = new DateTime(); }
    public Person(string firstName, string lastName, DateTime dateOfBirth) {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }
    public override string ToString()
    {
        return $"{_firstName} {_lastName}, data ur. {_dateOfBirth}";
    }
    public virtual void Details()
    {
        Console.WriteLine(ToString());
    }
}

public class Grade
{
    private string _subjectName = "";
    private DateTime _date;
    private double _value;

    public string SubjectName { get { return _subjectName; } set { _subjectName = value; }}
    public DateTime Date { get { return _date;} set { _date = value; } } 
    public double Value { get { return _value;} set { _value = value; } }   
    
    public Grade() { _date = new DateTime(); }
    public Grade(string subjectName, double value, DateTime date)
    {
        _subjectName = subjectName;
        _value = value;
        _date = date;
    }

    public override string ToString()
    {
        return $"{_subjectName} : {_value}, {_date}";
    }
    public void Details()
    {
        Console.WriteLine(ToString());
    }
}

public class Student : Person {
    private int _year;
    private int _group;
    private int _indexId;
    private List<Grade> _grades;

    public int Year { get { return _year; } set { _year = value; } }
    public int Group { get { return _group; } set { _group = value; } }
    public int IndexId { get { return _indexId; } set { _indexId = value; } }
    public List<Grade> Grades { get { return _grades; } }

    public Student() : base() { _grades = new List<Grade>(); }
    public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
    {
        _year = year;
        _group = group;
        _indexId = indexId;
        _grades = new List<Grade>();
    }
    
    public override string ToString()
    {
        string result = base.ToString() + $", {_year} rok studiow, grupa {_group}, id {_indexId}. lista ocen: \n";
        foreach (Grade grade in _grades) result += grade.ToString() + '\n'; 
        return result;
    }
    
    public void AddGrade(string subjectName, double value, DateTime date)
    {
        _grades.Add(new Grade(subjectName, value, date));
    }
    public void AddGrade(Grade grade) {
        _grades.Add(grade);
    }
    public void DisplayGrades()
    {
        Console.WriteLine(_grades);
    }
    public void DisplayGrades(string subjectName)
    {
        foreach (Grade grade in _grades)
        {
            if (grade.SubjectName == subjectName) Console.WriteLine(grade);
        }
    }
    public void DeleteGrade(string subjectName, double value, DateTime date)
    {
        _grades.Remove(_grades.FirstOrDefault(
            b => b.SubjectName == subjectName &&
            b.Value == value &&
            b.Date == date)
        );
    }
    public void DeleteGrade(Grade grade)
    {
        _grades.Remove(grade);
    }
    public void DeleteGrades(string subjectName)
    {
        _grades.RemoveAll(b => b.SubjectName == subjectName);
    }
    public void DeleteGrades()
    {
        _grades.Clear();
    }
}

public class Player : Person{
    private string _position = "";
    private string _club = "";
    private int _scoredGoals;

    public string Position { get { return _position; } set { _position = value; } }
    public string Club { get { return _club; } set { _club = value; } }
    public int ScoredGoals { get {  return _scoredGoals; } set { _scoredGoals = value; } }

    public Player():base() { }
    public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals = 0) :base(firstName,lastName,dateOfBirth) {
        _position = position;
        _club = club;   
        _scoredGoals=scoredGoals;
    }
    public override string ToString()
    {
        return base.ToString() + $", {_position}, klub {_club}, {_scoredGoals} scored goals";
    }
    public virtual void ScoreGoal()
    {
        _scoredGoals++;
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

public class FootballPlayer : Player
{
    public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals =0 ): base(firstName, lastName, dateOfBirth, position, club, scoredGoals) { }
    public override void ScoreGoal()
    {
        base.ScoreGoal();
        Console.WriteLine("Football player scored goal!");
    }
}


class Program
{
    public static int Main(string[] args)
    {
        Console.WriteLine("ZADANIE 1 ----------------------------");

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

        Console.WriteLine("ZADANIE 2 ----------------------------");

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

        Console.WriteLine("ZADANIE 3 ----------------------------");

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

        return 0;
    }
}