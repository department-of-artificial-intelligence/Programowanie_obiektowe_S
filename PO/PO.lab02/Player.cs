using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab02
{
    public class Player : Person
    {
        private string _position = null!;
        private string _club = null!;
        private int _scoredGoals;
        public string Position { get => _position; set => _position = value; }
        public string Club { get => _club; set => _club = value; }
        public int ScoredGoals { get => _scoredGoals; set => _scoredGoals = value; }
        public Player() : base() 
        {
            _position = "Without position";
            _club = "No club";
            _scoredGoals = 0;
        }
        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals) : base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }
        public override string ToString()
        {
            return base.ToString() + $" | Position: {_position} | Club: {_club} | Scored Goals: {_scoredGoals}";
        }

        public virtual void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
