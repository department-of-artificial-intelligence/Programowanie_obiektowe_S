using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace Lab1.App
{
    public class Person
    {
        protected string? _firstName;
        public string? FirstName => _firstName;
        protected string? _lastName;
        public string? LastName => _lastName;
        protected DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }

        public Person()
        {
            _firstName = "none";
            _lastName = "none";
            _dateOfBirth = DateTime.Now;
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth) { 
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Person | First Name: {_firstName}, Last name: {_lastName}, Date of birth: {_dateOfBirth}\n";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }


    }

    public class Student: Person
    {
        private int _year;
        public int Year
        {
            get => _year;
            set => _year = value;
        }
        private int _group;
        public int Group
        {
            get => _group;
            set => _group = value;
        }
        private int _indexId;
        public int IndexId
        {
            get => _indexId;
            set => _indexId = value;
        }

        private List<Grade> _grades;

        public Student()
            :base()
        {
            _firstName= "none";
            _lastName= "none";
            _dateOfBirth= DateTime.Now;
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();
            
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId, List<Grade> grades )
            :base(firstName, lastName, dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _year = year;
            _group = group;
            _indexId = indexId;
            _grades = new List<Grade>(grades);
        }

        public override string ToString()
        {
            return $"Student | First Name: {_firstName}, Last name: {_lastName}, Date of birth: {_dateOfBirth}, Year: {_year}, Group: {_group}, Index Id: {_indexId}\n";
        }

        public override void Details()
        {
            base.Details();
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
           
        }
    }

    public class Player: Person
    {
        private string? _position;
        public string? Position => _position;
        private string? _club;
        public string? Club => _club;
        private int _scoredGoals;
        public int ScoredGoals
        {
            get => _scoredGoals;
            set => _scoredGoals = value;
        }

        public Player()
            :base()
        {
            _firstName = "none";
            _lastName = "none";
            _dateOfBirth = DateTime.Now;
            _position = "none";
            _club = "none";
            _scoredGoals = 0;

        }
        public Player(string firstName, string lastName,DateTime dateOfBirth, string position, string club, int scoredGoals)
            :base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

        public override string ToString()
        {
            return $"Player | First Name: {_firstName}, Last name: {_lastName}, Date of birth: {_dateOfBirth}, Position: {_position}, Club: {_club}, Scored goals: {_scoredGoals}\n";

        }
        
        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }

    public class Grade
    {
        private string? _subjectName;
        public string? SubjectName => _subjectName;
        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        private double _value;
        public double Value
        {
            get => _value;
            set => _value = value;
        }

        public Grade()
        {
            _subjectName = "none";
            _date = DateTime.Now;
            _value = 0;
        }
        public Grade(string? subjectName, DateTime date, double value)
        {
            _subjectName = subjectName;
            _date = date;
            _value = value;
        }

        public override string ToString()
        {
            return $"Grade | Subject name: {_subjectName}, Date: {_date}, Value: {_value}\n";

        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }

    class Program
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
        }
    }
}


