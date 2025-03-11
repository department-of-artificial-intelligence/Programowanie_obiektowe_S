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
            Position = "nieznana";
            Club = "nieznany";
            ScoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Club = club;
            ScoredGoals = scoredGoals;
        }

        public override string ToString()
        {
            string details = $"Player | Position: {Position}, Club: {Club}, ScoredGoals: {ScoredGoals} " + base.ToString();
            return details;
        }

        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
