using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player : Person
    {
        private string _position;
        private string _club;
        private int _scoreGoals;

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

        public int ScoreGoals
        {
            get { return _scoreGoals; }
            set { _scoreGoals = value; }
        }

        public Player()
            :base()
        {
            _position = string.Empty;
            _club = string.Empty;
            _scoreGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth,string position,string club,int scoreGoals)
            : base(firstName, lastName, dateOfBirth)
        {
            _position=position;
            _club=club;
            _scoreGoals=scoreGoals;
        }

        public override string ToString()
        {
            return base.ToString() + $"Player | Position: {_position}, Club: {_club}, ScoreGoals: {_scoreGoals}";
        }

        public void ScoreGoal()
        {
            _scoreGoals++;
        }
    }
}
