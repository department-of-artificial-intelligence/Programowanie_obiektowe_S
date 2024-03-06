using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Player : Person
    {
        protected string _position, _club;
        protected int _scoredGoals;
        public string Position
        {
            get => _position;
            set => _position = value;
        }
        public string Club
        {
            get => _club;
            set => _club = value;
        }
        public int ScoredGoals
        {
            get => _scoredGoals;
        }
        public Player() { }
        public Player(string firstName, string lastName, DateTime date,
                      string position, string club, int goals)
            : base (firstName, lastName, date)
        {
            Position = position;
            Club = club;
            _scoredGoals = goals;
        }
        public override void Details()
        {
            var message = $"Player: {base.ToString()}; Goals: {ScoredGoals}; and other";
            Console.WriteLine(message);
        }
        public void ScoreGoal()
        {
            this._scoredGoals++;
        }
    }
}
