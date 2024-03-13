using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Po.Lab2
{
    public class Player : Person
    {
        private string _position;
        private string _club;
        private int? _scoreGoals;

        public string Club { get => _club; set => _club = value; }
        public string Position { get => _position; set => _position = value; }
        public int ScoreGoal { get => (int)_scoreGoals; set => _scoreGoals = value; }

        public Player()
        {
            _position = null;
            _club = null;
            _scoreGoals = 0;
        }
        public Player(string firstName, string lastName,
            DateTime birthDate, string position, string club, int scoreGoals
            ) : base(firstName, lastName, birthDate)
        {
            _position = position;
            _club = club;
            _scoreGoals = scoreGoals;
        }
        public override string ToString()
        {
            return base.ToString() + $"Position: {_position}, Club:{_club}" +
                $", ";
        }
        public void ScoreGoals()
        {
            _scoreGoals++;
        }
    }
   
}

