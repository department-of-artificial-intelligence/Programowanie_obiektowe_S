using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace PO.Lab2
{
    class Program
    {
        public class Person
        {
            protected string _firstName;
            protected string _lastName;
            protected DateTime _dateOfBirth;

            public string FirstName { get { return _firstName; } set { _firstName = value; } }
            public string LastName { get { return _lastName; } set { _lastName = value; } }
            public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
            public Person() 
            {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _dateOfBirth = DateTime.MinValue;
            }
            public Person(string firstName, string lastName, DateTime dateOfBirth)
            {
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
            }
            public override string ToString()
            {
                return $"firstName: {_firstName}, lastName: {_lastName}, dateOfBirth: {_dateOfBirth}";
            }
            public virtual void Details()
            {
                Console.WriteLine(this.ToString());
            }
        }
        public class Student : Person
        {
            private int _year;
            private int _group;
            private int _indexId;
            private List<Grades> _grades;

            public int Year { get { return _year; } set { _year = value; } }
            public int Group { get { return _group;} set { _group = value; } }
            public int IndexId { get { return _indexId;} set { _indexId = value; } }
            public List<Grades> Grades { get { return _grades; }}

            public Student()
                :base()
            { 
                _year = 0;
                _group = 0; 
                _indexId = 0;
              //  _grades = new List<Grades>();
            }
            public Student(string firstName, string lastName, DateTime dateOfBirth, int year, int group, int indexId)
                :base(firstName, lastName, dateOfBirth)
            {
                _year=year;
                _group=group;
                _indexId=indexId;
              //  _grades = new List<Grades>();
            }
            public override string ToString()
            {
                if(_grades == null)
                    _grades = new List<Grades>();
                string Line = string.Empty;
                foreach(Grades Ocenka in _grades)
                {
                    Line += '\n' + Ocenka.ToString();
                }
                return base.ToString() + $"year: {_year}, group: {_group}, indexId: {_indexId}" + Line;
            }
            public void AddGrade(string SubjectName, double value, DateTime date)
            {
                Grades NewGrades = new Grades(SubjectName, date, value);
                if (_grades == null)
                    _grades = new List<Grades>();
                _grades.Add(NewGrades);
            }
            public void AddGrade(Grades grade)
            {
                if (_grades == null)
                    _grades = new List<Grades>();
                _grades.Add(grade);
            }
            public void DisplayGrades()
            {
                foreach(Grades Ocenka in _grades)
                {
                    Console.WriteLine(Ocenka.ToString());
                }
            }
            public void DisplayGrades(string SubjectName)
            {
                foreach (Grades Ocenka in _grades)
                {
                    if(Ocenka.SubjectName == SubjectName)
                    Console.WriteLine(Ocenka.ToString());
                }
            }
            public void DeleteGrade(string subjectName, double value, DateTime date)
            {
                for(int i = 0; i < _grades.Count(); i++)
                {
                    if (_grades[i].SubjectName == subjectName && _grades[i].Value == value && _grades[i].Date == date)
                        _grades.RemoveAt(i);
                }
            }
            public void DeleteGrade(Grades grade)
            {
                for (int i = 0; i < _grades.Count(); i++)
                {
                    if (_grades[i].SubjectName == grade.SubjectName && _grades[i].Value == grade.Value && _grades[i].Date == grade.Date)
                        _grades.RemoveAt(i);
                }
            }
            public void DeleteGrade()
            {
                 _grades.Clear();
            }
            public void DeleteGrade(string subjectName)
            {
                for (int i = 0; i < _grades.Count(); i++)
                {
                    if (_grades[i].SubjectName == subjectName)
                        _grades.RemoveAt(i);
                }
            }
        }

        public class Grades
        {
            private string _subjectName;
            private DateTime _date;
            private double _value;

            public string SubjectName
            {
                get { return _subjectName; }
                set { _subjectName = value; }
            }
            public DateTime Date 
            {
                get { return _date; } 
                set { _date = value; } 
            }
            public double Value
            {
                get { return _value; }
                set { _value = value; }
            }
            public Grades()
            {
                _subjectName = string.Empty;
                _date = DateTime.MinValue;
                _value = 0;
            }
            public Grades(string subjectName, DateTime date, double value)
            {
                SubjectName = subjectName;
                Date = date;
                Value = value;
            }
            public override string ToString()
            {
                return $"SubjectName: {_subjectName}, Date: {_date}, Value: {_value}";
            }
            public void Details()
            {
                Console.WriteLine(this.ToString());
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
                :base()
            {
                _position = string.Empty;
                _club = string.Empty;
                _scoredGoals = 0;
            }
            public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredgoals) 
                :base(firstName,  lastName,  dateOfBirth)
            {
                _position = position;
                _club = club;
                _scoredGoals =scoredgoals;
            }
            public override string ToString()
            {
                return base.ToString() + $"position: {_position}, club: {_club}, scoredgoals: {_scoredGoals}";
            }
            public virtual void ScoreGoal()
            {
                _scoredGoals++;
            }

        }
        public class HandballPlayer : Player
        {
            public HandballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int Scoredgoals = 0)
                : base(firstName, lastName, dateOfBirth, position, club, Scoredgoals)
            {}
            public override void ScoreGoal()
            {
                base.ScoreGoal();
                Console.WriteLine("Handball player scored goal!");
            }
        }
        public class FootballPlayer : Player
        {
            public FootballPlayer(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int Scoredgoals = 0)
                : base(firstName, lastName, dateOfBirth, position, club, Scoredgoals)
            { }
            public override void ScoreGoal()
            {
                base.ScoreGoal();
                Console.WriteLine("Football player scored goal!");
            }
        }

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

            ((Student)person2).AddGrade("PO", 5.0D, new DateTime(2011, 2, 20));
            ((Student)person2).AddGrade("Bazy Danych", 5.0D, new DateTime(2011, 2, 13));
            person2.Details();
            Grades grade = new Grades("Bazy Danych", new DateTime(2011, 5, 1), 5.0D);
            student.AddGrade(grade);
            student.AddGrade("AWWW", 5.0D, new DateTime(2011, 5, 11));
            student.AddGrade("AWWW", 4.5D, new DateTime(2011, 4, 2));
            student.DisplayGrades();
            student.Details();
            student.DeleteGrade("AWWW", 4.5D, new DateTime(2011, 4, 2));
            student.Details();
            student.DeleteGrade("AWWW");
            student.Details();
            student.AddGrade("AWWW", 5.0D, new DateTime(2011, 4, 3));
            student.DeleteGrade();
            student.Details();
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

        }


    }
}
