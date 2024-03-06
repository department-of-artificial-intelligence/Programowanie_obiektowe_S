using System.Numerics;
using System.Text.RegularExpressions;

namespace lab2
{
    public class Person {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public Person() { 
            _firstName = string.Empty;
            _lastName = string.Empty;
            _dateOfBirth = DateTime.MinValue;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName=firstName;
            _lastName=lastName;
            _dateOfBirth=dateOfBirth;
        }

        public override string ToString()
        {
            return $"{_firstName}, {_lastName}, {_dateOfBirth}";
        }
        public virtual void Details(){
            Console.WriteLine(this.ToString());
        }
    }

    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        public int Year { get { return _year; } set { _year = value; } }
        public int Group { get { return _group;} set { _group = value; } }
        public int IndexId { get { return _indexId; } set { _indexId = value; } }
        public Student() { _year = 0; _group = 0; _indexId = 0; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
            : base(firstName, lastName, dateOfBirth) 
        {
            _year = year;
            _group = group;
            _indexId = indexId;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {_year}, {_group}, {_indexId}";
        }
    }

    public class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public string Position { get { return _position; } set { _position = value; } }
        public string Club { get { return _club; } set { _club = value; } }
        public int ScoredGoals { get { return _scoredGoals; } set { _scoredGoals = value; } }

        public Player()
        {
            _position = string.Empty;
            _club = string.Empty;
            _scoredGoals = 0;
        }
        public Player(string firstName, string lastName, DateTime dateOfBirth
            , string position, string club, int scoredGoals)
            : base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {_position}, {_club}, {_scoredGoals}";
        }

        public void ScoreGoal()
        {
            _scoredGoals++;
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
