using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
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
            set { _scoredGoals = value; }
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

}
