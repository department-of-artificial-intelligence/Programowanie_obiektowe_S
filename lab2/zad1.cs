using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using time;

namespace lab2
{
    internal class zad1 { 
        public class Person
    {
        protected string _firstname;
        protected string _Lastname;
        protected DateTime _dateOfBirth;

        public string FirstName{ get; set;}
        public string LastName { get; set;}
        public DateTime DateOfBirth { get; set;}

            public Person() { }
        public Person(string firstName, string lastname, DateTime dateOfBirth) {
                FirstName = firstName;
                LastName = lastname;
                DateOfBirth = dateOfBirth;


        }
            public string ToString()
            {
                return FirstName;
            }

           virtual public void Details()
            {
                Console.WriteLine(FirstName, LastName, DateOfBirth );
            }
    }

        public class Student : Person
        {
            private int _year;
            private int _group;
            private int _indexid;

            public int Year { get; set;}
            public int Group { get; set;}
            public int Indexid { get; set;}

            public Student() { }

            public Student(string firstName, string lastname, DateTime dateOfBirth, int year, int group, int indexid)
            {
                FirstName = firstName;
                LastName = lastname;
                DateOfBirth = dateOfBirth;
                Year = year;
                Group = group;
                Indexid = indexid;

            }

            public string ToString()
            {
                return base.ToString();
            }
        }

        public class Player: Person
        {
            private string _position;
            private string _club;
            private int _scoredGoals;

            public string Position { get { return _position; } set { _position = value; } }
            public string Club { get { return _club; } set { _club = value; } }

            public int ScoredGoals { get; set; }

            Player() { }

            Player(string firstName, string lastname, DateTime dateOfBirth, string position, string club, int scoredGoals)
            {
                FirstName = firstName;
                LastName = lastname;
                DateOfBirth = dateOfBirth;
                Position = position;
                Club = club;
                ScoredGoals = scoredGoals;
            }

            public string ToString()
            {
                return base.ToString();
            }

            public void ScoreGoal()
            {

            }
        }

    
        static void Main(string[] args)
        {
            Person.Details();
            Console.WriteLine("Hello, World!");
        }
    }
}
