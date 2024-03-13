using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Player : Person
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
            _position = "nieznana";
            _club = "nieznany";
            _scoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

        public override string ToString()
        {
            return $"Person | Player | First name: {_firstName}, Last name: {_lastName}, Date of birth: {_dateOfBirth}, Position: {_position}, Club: {_club}, Scored goals: {_scoredGoals}";
        }

        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
