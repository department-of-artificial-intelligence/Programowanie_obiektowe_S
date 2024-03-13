using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
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
            _position = "";
            _club = "";
            _scoredGoals = 0;
        }

        public Player(string firstname, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
            : base(firstname, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

        public override string ToString() { return base.ToString()+ $", Position: {_position}, Club: {_club}, ScoredGoals: {_scoredGoals}"; }

        public void ScoreGoal() { _scoredGoals++; }
    }
}
