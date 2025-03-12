namespace lab2
{
    internal class Program
    {
        public class Person
        {
            protected string _firstName;
            protected string _lastName;
            protected DateTime _dateOfBirth;

            public string FirstName { get => _firstName; set => _firstName = value; }

            public string LastName { get => _lastName; set => _lastName = value; }

            public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }

            public Person()
            {
                _firstName = "No defined";
                _lastName = "No defined";
                _dateOfBirth = DateTime.Now;
            }

            public Person(string firstName, string lastName, DateTime dateOfBirth)
            {
                _firstName = firstName;
                _lastName = lastName;
                _dateOfBirth = dateOfBirth;
            }

            public virtual void Details()
            {
                Console.WriteLine(ToString());
            }

            public override string ToString()
            {
                return $"Person: {FirstName} {LastName}, Date of birth: {DateOfBirth}";
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

            public Student() : base()
            {
                _year = 0;
                _group = 0;
                _indexId = 0;
            }

            public Student(int year, int group, int indexId) : base(firstName, lastName, dateOfBirth)
            {
                _year = year;
                _group = group;
                _indexId = indexId;
            }

            public override string ToString()
            {
                return base.ToString() + $"Year: {Year}, Group: {Group}, Index ID: {IndexId}";
            }
        }

        public class Player : Person
        {
            private string _position;
            private string _club;
            private int _scoredGoals;

            public string Position { get => _position; set => _position = value; }
            public string Club { get => _club; set => _club = value; }
            public int ScoredGoals { get => _scoredGoals; set => _scoredGoals = value; }

            public Player() : base()
            {
                _position = "No defined";
                _club = "No defined";
                _scoredGoals = 0;
            }

            public Player(string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
            {
                _position = position;
                _club = club;
                _scoredGoals = scoredGoals;
            }

        }
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
}
