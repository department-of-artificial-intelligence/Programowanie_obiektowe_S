using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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

        public Player() : base()
        {
            _position = string.Empty;
            _club = string.Empty;
            _scoredGoals = 0;
        }

        public Player(string firstName,  string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals):base(firstName, lastName,dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

        public override string ToString()
        {
            return base.ToString() + $", position: {_position}, club: {_club}, scored goals: {_scoredGoals}";
        }

        public override void Details()
        {
            Console.WriteLine("Player | " + ToString());
        }

        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }


}
