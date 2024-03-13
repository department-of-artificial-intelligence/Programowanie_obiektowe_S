using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Po.Lab2
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime? _birthDate;

        public string FirstName
        {
            get => _firstName; set =>
                _firstName = value;
        }
        public string LastName
        {
            get => _lastName; set =>
                _lastName = value;
        }
        public DateTime BirthDate
        {
            get => (DateTime)_birthDate; set =>
                _birthDate = value;
        }
        public Person()
        {
            _firstName = null;
            _lastName = null;
            _birthDate = null;
        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }
        public override string ToString()
        {
            return $"First Name: {_firstName}, " +
                $"Last Name: {_lastName}, Birth Date: {_birthDate}";
        }
        public virtual void Details()
        {
            this.ToString();
        }

    }
    public class Student : Person
    {
        private int _year;
        private int _group;
        private int _indexId;

        public int Year { get => _year; set => _year = value; }
        public int Group { get => _group; set => _group = value; }
        public int IndexId { get => _indexId; set => _indexId = value; }

        public Student()
        {
            _group = 0;
            _year = 0;
            _indexId = 0;
        }
        public Student(string firstName, string lastName, DateTime birthDate, int year,
            int group, int indexId) : base(firstName, lastName, birthDate)
        {
            _group = group;
            _indexId = indexId;
            _year = year;
        }
        public override string ToString()
        {
            return base.ToString() + $"Year: {_year}, Group: {_group}" +
                $", Index: {_indexId}";
        }
        public override void Details()
        {
            base.Details();
        }
    }
    public class Player : Person
    {
        private string _position;
        private string _club;
        private int? _scoreGoals;

        public string Club { get => _club; set => _club = value; }
        public string Position { get => _position; set => _position = value; }
        public int ScoreGoal { get => (int)_scoreGoals; set => _scoreGoals = value; }

        public Player()
        {
            _position = null;
            _club = null;
            _scoreGoals = 0;
        }
        public Player(string firstName, string lastName,
            DateTime birthDate, string position, string club, int scoreGoals
            ) : base(firstName, lastName, birthDate)
        {
            _position = position;
            _club = club;
            _scoreGoals = scoreGoals;
        }
        public override string ToString()
        {
            return base.ToString() + $"Position: {_position}, Club:{_club}" +
                $", ";
        }
        public void ScoreGoals()
        {
            _scoreGoals++;
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
            ((Player)person3).ScoreGoals();
            person3.Details();
        }
    }
}
