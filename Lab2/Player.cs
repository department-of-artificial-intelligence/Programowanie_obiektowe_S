using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            get => _position;
            set => _position = value;
        }

        public string Club
        {
            get => _club;
            set => _club = value;
        }

        public int ScoredGoals { get; set; }

        public Player() 
            : base()
        {
            _position = "none";
            _club = "none";
            _scoredGoals = 0;
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth, string position, string club, int scoredGoals)
            : base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _club = club;
            _scoredGoals = scoredGoals;
        }

        public override string ToString() => base.ToString() + $" {Position} {Club} {ScoredGoals}";

        public virtual void ScoreGoal()
        {
            _scoredGoals += 1;
        }
    } 
}
