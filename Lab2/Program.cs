using Microsoft.VisualBasic;
using System.Runtime.InteropServices.Marshalling;

namespace Lab2
{
    internal class Program
    {
        public class Person
        {
            protected string _firstName;
            protected string _lastName;
            protected DateTime _dateOfBirth;

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }

            public DateTime DateOfBirth
            {
                get { return _dateOfBirth; }
                set { _dateOfBirth = value; }
            }
            public Person()
            {
                FirstName = "none";
                LastName = "none";
                DateOfBirth = DateTime.MinValue;
            }

            public Person(string firstName, string lastName, DateTime dateOfBirth)
            {
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
            }

            public override string ToString()
            {
                return $"Person | First Name: {_firstName}, Last Name: {_lastName}, Date Of Birth: {_dateOfBirth}";
            }

            public virtual void Details()
            {
                Console.WriteLine(this);
            }

        }

        public class Player : Person
        {
            private string _position;
            private string _club;
            private int _scoredGoals;

            public string Position
            {
                get { return _position; }
                set { _position = value; } 
            }
            public string Club
            {
                get { return _club; }
                set { _club = value; }
            }
            public int ScoredGoals
            {
                get { return _scoredGoals; }
                set { _scoredGoals = value;}
            }

            public Player()
            {
                Position = "none";
                Club = "none";
                ScoredGoals = 0;
            }
            public Player(string FirstName, string LastName, DateTime dateOfBirth, string position, string club, int scoredGoals) 
                : base(firstname), base(lastname),
            {
                _position = position;
                _club = club;
                _scoredGoals = scoredGoals;
            }

            public override string ToString()
            {
                base.ToString();
                return $"Player: Position:{_position}, Club : {_club}, ScoredGoals : {_scoredGoals}";
            }

            public void ScoreGoal()
            {
                _scoredGoals++;
            }
        }

        public class Student : Person
        {
            private int _year;
            private int _group;
            private int _indexId;

            public int Year
            {
                get { return _year; }
                set { _year = value; }
            }
            public int Group
            {
                get { return _group; }
                set { _group = value; }
            }
            public int IndexId
            {
                get { return _indexId; }
                set { _indexId = value; }
            }

            public Student()
            {
                _year = 0;
                _group = 0;
                _indexId = 0;
            }
            
        }

        static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
    }
}
