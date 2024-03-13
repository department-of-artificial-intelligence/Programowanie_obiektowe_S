using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Player:Person
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
            set { _scoredGoals = value; }
        }
        public Player()
        {
            _position = "nieznany";
            _club = "nieznany";
            _scoredGoals = 0;
        }
        public Player(string firstName, string lastName, DateTime dateofBirth, string position, string club, int scoredGoals)
        {
            _firstName = firstName;
            _lastName = lastName;
            _DateTime = dateofBirth;
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }
        public override string ToString()
        {
            return $"Imie: {_firstName} | Nazwisko {_lastName} | Data urodzenia {_DateTime}| pozycja {_position} | klub {_club} | ilosc goli {_scoredGoals}";

        }
        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
