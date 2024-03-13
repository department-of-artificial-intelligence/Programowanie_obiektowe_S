using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DK
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
            _position = "None";
            _club = "None";
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
            return base.ToString() + $" position: {_position} club: {_club} scoredGoals {_scoredGoals}";
        }
        public override void Details()
        {
            Console.WriteLine(this.ToString() + "\n");
        }
        public void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
